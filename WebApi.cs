using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

public class SuratHesabProcessor
{
    private SqlConnection _t_connection1;
    private SqlConnection _t_connection2;

    // سازنده کلاس - اتصال به دیتابیس ایجاد می‌شود
    public SuratHesabProcessor(string connectionString1, string connectionString2)
    {
        _t_connection1 = new SqlConnection(connectionString1);
        _t_connection2 = new SqlConnection(connectionString2);
    }

    // متد اصلی برای پردازش چندنخی روی داده‌های مشتریان
    public void SuratHesabMoshtari()
    {
        int batchSize = 5;

        // فرض می‌کنیم این تابع داده را از دیتابیس می‌گیرد
        DataTable dataTable = FillData("SELECT * FROM moshtari WHERE id > 0");

        int totalRows = dataTable.Rows.Count;
        int totalBatches = (int)Math.Ceiling((double)totalRows / batchSize);

        Thread thread1 = null;
        Thread thread2 = null;

        for (int i = 0; i < totalBatches; i++)
        {
            // دسته داده‌ها برای پردازش
            string ids = "";
            string codeHesabs = "";

            int startIndex = i * batchSize;
            int endIndex = Math.Min(startIndex + batchSize, totalRows);

            for (int j = startIndex; j < endIndex; j++)
            {
                ids += dataTable.Rows[j]["id"].ToString() + ",";
                codeHesabs += dataTable.Rows[j]["codehesab_id"].ToString() + ",";
            }

            ids = RemoveLast(ids);
            codeHesabs = RemoveLast(codeHesabs);

            string param = $"{ids};{codeHesabs}";

            // اجرای همزمان در دو نخ (اگر نخ قبلی تمام شده باشد)
            if (thread1 == null || !thread1.IsAlive)
            {
                thread1 = new Thread(o => Do_process(o.ToString()));
                thread1.Name = "Thread1";
                thread1.Start(param);
            }
            else if (thread2 == null || !thread2.IsAlive)
            {
                thread2 = new Thread(o => Do_process(o.ToString()));
                thread2.Name = "Thread2";
                thread2.Start(param);
            }
            else
            {
                // اگر هر دو نخ مشغول بودند، منتظر پایان یکی باشیم
                thread1.Join();
                thread2.Join();

                // بعد از پایان، دوباره شروع می‌کنیم
                thread1 = new Thread(o => Do_process(o.ToString()));
                thread1.Name = "Thread1";
                thread1.Start(param);
            }
        }

        // اطمینان از اتمام نخ‌ها
        if (thread1 != null && thread1.IsAlive) thread1.Join();
        if (thread2 != null && thread2.IsAlive) thread2.Join();
    }

    // تابع کمکی برای خواندن داده‌ها از دیتابیس
    private DataTable FillData(string query)
    {
        DataTable dt = new DataTable();
        try
        {
            using (SqlConnection conn = new SqlConnection(_t_connection1.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // مدیریت خطاها (لاگ یا پیام مناسب)
            Console.WriteLine("Error in FillData: " + ex.Message);
        }
        return dt;
    }

    // حذف کامای آخر رشته
    private string RemoveLast(string text)
    {
        if (string.IsNullOrEmpty(text))
            return text;
        if (text.EndsWith(","))
            return text.Substring(0, text.Length - 1);
        return text;
    }

    // تبدیل DataTable به JSON ساده (بر اساس ستون‌های مشخص)
    private string ToJson(DataTable dt, List<string> columns)
    {
        var sb = new StringBuilder();
        sb.Append("[");

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            DataRow row = dt.Rows[i];
            sb.Append("{");
            for (int j = 0; j < columns.Count; j++)
            {
                string colName = columns[j];
                object val = row[colName];
                bool isString = val is string || val is DateTime;

                sb.Append($"\"{colName}\":");
                if (val == DBNull.Value)
                {
                    sb.Append("null");
                }
                else if (isString)
                {
                    sb.Append($"\"{val.ToString().Replace("\"", "\\\"")}\"");
                }
                else
                {
                    sb.Append(val);
                }

                if (j < columns.Count - 1)
                    sb.Append(",");
            }
            sb.Append("}");

            if (i < dt.Rows.Count - 1)
                sb.Append(",");
        }

        sb.Append("]");
        return sb.ToString();
    }

    // ارسال داده‌ها به API
    private void Send(DataTable dt, List<string> columns)
    {
        string json = ToJson(dt, columns);
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:8000/api/surat");
        request.ContentType = "application/json";
        request.Accept = "application/json";
        request.Method = "POST";

        using (var streamWriter = new StreamWriter(request.GetRequestStream()))
        {
            streamWriter.Write(json);
        }

        using (WebResponse response = request.GetResponse())
        {
            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                string responseText = sr.ReadToEnd();
                Console.WriteLine("Response from API: " + responseText);
            }
        }
    }

    // متد فرضی Do_process که با داده‌های رشته‌ای کار می‌کند
    private void Do_process(string param)
    {
        // param شامل "ids;codehesab_ids"
        Console.WriteLine($"Processing: {param}");

        // در اینجا عملیات واقعی شما برای پردازش داده‌ها انجام می‌شود
        // مثل واکشی اطلاعات، تبدیل، ارسال به API و غیره

        // نمونه ساده: فقط چاپ و شبیه‌سازی تاخیر
        Thread.Sleep(1000);
    }
}

﻿using System;
using System.Text;
using System.Net;
using System.IO;
using Microsoft.VisualBasic.FileIO;

// 開発名 : サイドキック（相棒）
// 内容   : 気象情報を加工するプログラム

namespace SideKick
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WebClient wctd = new WebClient();
                wctd.DownloadFile(
                  "https://www.data.jma.go.jp/obd/stats/data/mdrr/pre_rct/alltable/pre1h00_rct.csv",
                  "pre01.csv");

                var parser = new TextFieldParser(@"pre01.csv",
                Encoding.GetEncoding("Shift_JIS"));
                using (parser)
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    parser.HasFieldsEnclosedInQuotes = true;
                    parser.TrimWhiteSpace = false;

                    while (!parser.EndOfData)
                    {
                        StreamWriter sw = new StreamWriter(
                        "tenki.txt",
                        true,
                        Encoding.UTF8);

                        Console.SetOut(sw);

                        string[] row = parser.ReadFields();
                        foreach (string field in row)
                        {
                            Console.Write(field + "\t");
                        }
                        Console.WriteLine();
                        sw.Dispose();
                    }
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                GC.Collect();
            }

        }
    }
}
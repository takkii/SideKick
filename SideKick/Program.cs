using System;
using System.Text;
using System.Net;
using Microsoft.VisualBasic.FileIO;

namespace SideKick
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient wctd = new WebClient();
            wctd.DownloadFile(
              "https://www.data.jma.go.jp/obd/stats/data/mdrr/pre_rct/alltable/pre1h00_rct.csv",
              "pre01.csv");

            var parser = new TextFieldParser(@"pre01.csv",
            Encoding.GetEncoding("Shift_JIS"));
            using (parser)
            {
                // カンマ区切りの指定
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                // フィールドが引用符で囲まれているか
                parser.HasFieldsEnclosedInQuotes = true;
                // フィールドの空白トリム設定
                parser.TrimWhiteSpace = false;

                // ファイルの終端までループ
                while (!parser.EndOfData)
                {
                    // フィールドを読込
                    string[] row = parser.ReadFields();
                    foreach (string field in row)
                    {
                        // タブ区切りで出力
                        Console.Write(field + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
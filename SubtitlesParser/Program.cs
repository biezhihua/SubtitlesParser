using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SubtitlesParser.Classes;

namespace Test
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var parser = new SubtitlesParser.Classes.Parsers.SsaParser();


            var fileStream = new FileStream("/Users/biezhihua/Downloads/Greys.Anatomy.S13E15.720p.HDTV.X264-DIMENSION.繁体&英文.ass", FileMode.Open);
            List<SubtitleItem> result = parser.ParseStream(fileStream, Encoding.UTF8);
            Console.WriteLine(result);

//            var parser = new SubtitlesParser.Classes.Parsers.SubViewerParser();
//            var fileStrema = new FileStream("/Users/biezhihua/Downloads/Greys.Anatomy.S13E15.720p.HDTV.X264-DIMENSION.繁体&英文.ass", FileMode.Open);

//            List<SubtitleItem> result = parser.ParseStream(fileStrema, Encoding.UTF8);
//            Console.WriteLine();
        }
    }
}
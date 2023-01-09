using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GenerateCode.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CodeGenerateController : ControllerBase
    {
        public string metin = "ACDEFGHKLMNPRTXYZ234579";
	    public double ms = 20000;

        [HttpGet("/CodeGenerate")]
        public string Get()
        {
            return CodeGenerated();
        }

        private string CodeGenerated()
        {
            var dateNow = DateTime.Now;
		    var date = DateTime.Now.AddMilliseconds(ms);
            var UnixTimeStamp = date.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            long timeStampInt = Convert.ToInt64(UnixTimeStamp);
            long timeStampIntQuatro = timeStampInt*timeStampInt*timeStampInt*timeStampInt;
            string timeStampIntSquareStr = timeStampIntQuatro.ToString();
		    timeStampIntSquareStr = timeStampIntSquareStr.StartsWith("-") ? timeStampIntSquareStr.Substring(1,timeStampIntSquareStr.Length-1) : timeStampIntSquareStr;

            int mode1 = Convert.ToInt16(timeStampIntSquareStr.Substring(5,2))%23;
            int mode2 = Convert.ToInt16(timeStampIntSquareStr.Substring(6,2))%23;
            int mode3 = Convert.ToInt16(timeStampIntSquareStr.Substring(7,2))%23;
            int mode4 = Convert.ToInt16(timeStampIntSquareStr.Substring(8,2))%23;
            int mode5 = Convert.ToInt16(timeStampIntSquareStr.Substring(9,2))%23;
            int mode6 = Convert.ToInt16(timeStampIntSquareStr.Substring(10,2))%23;
            int mode7 = Convert.ToInt16(timeStampIntSquareStr.Substring(11,2))%23;
            int mode8 = Convert.ToInt16(timeStampIntSquareStr.Substring(12,2))%23;

            string codeGen = "" + metin[Convert.ToInt16(mode8)] + metin[Convert.ToInt16(mode6)] + metin[Convert.ToInt16(mode4)] + metin[Convert.ToInt16(mode2)] + metin[Convert.ToInt16(mode1)] + metin[Convert.ToInt16(mode3)] + metin[Convert.ToInt16(mode5)] + metin[Convert.ToInt16(mode7)];

            return codeGen;
        }

        [HttpGet("/CodeChecked")]
        public bool CodeChecked(string code)
        {
            return CodeIsValid(code);
        }

        private bool CodeIsValid(string code)
        {
            bool checkCode = false;

            for(double i = 0; i<=ms; i=i+1000)
            {
                var date = DateTime.Now.AddMilliseconds(i);
                var UnixTimeStamp = date.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
                var timeStamp = Convert.ToInt64(UnixTimeStamp).ToString();
                long timeStampInt = Convert.ToInt64(UnixTimeStamp);
                long timeStampIntSquare = timeStampInt*timeStampInt*timeStampInt*timeStampInt;
                string timeStampIntSquareStr = timeStampIntSquare.ToString();
                timeStampIntSquareStr = timeStampIntSquareStr.StartsWith("-") ? timeStampIntSquareStr.Substring(1,timeStampIntSquareStr.Length-1) : timeStampIntSquareStr;
                

                int mode1 = Convert.ToInt16(timeStampIntSquareStr.Substring(5,2))%23;
                int mode2 = Convert.ToInt16(timeStampIntSquareStr.Substring(6,2))%23;
                int mode3 = Convert.ToInt16(timeStampIntSquareStr.Substring(7,2))%23;
                int mode4 = Convert.ToInt16(timeStampIntSquareStr.Substring(8,2))%23;
                int mode5 = Convert.ToInt16(timeStampIntSquareStr.Substring(9,2))%23;
                int mode6 = Convert.ToInt16(timeStampIntSquareStr.Substring(10,2))%23;
                int mode7 = Convert.ToInt16(timeStampIntSquareStr.Substring(11,2))%23;
                int mode8 = Convert.ToInt16(timeStampIntSquareStr.Substring(12,2))%23;
                
                // Console.WriteLine("Test :" + timeStampIntSquareStr.Substring(5,2) + " " + Convert.ToInt16(timeStampIntSquareStr.Substring(5,2)) + " " + Convert.ToInt16(timeStampIntSquareStr.Substring(5,2))%23 );
                // Console.WriteLine("Test :" + timeStampIntSquareStr.Substring(6,2) + " " + Convert.ToInt16(timeStampIntSquareStr.Substring(6,2)) + " " + Convert.ToInt16(timeStampIntSquareStr.Substring(6,2))%23  );
                // Console.WriteLine("Test :" + timeStampIntSquareStr.Substring(7,2) + " " + Convert.ToInt16(timeStampIntSquareStr.Substring(7,2)) + " " + Convert.ToInt16(timeStampIntSquareStr.Substring(7,2))%23  );
                // Console.WriteLine("Test :" + timeStampIntSquareStr.Substring(8,2) + " " + Convert.ToInt16(timeStampIntSquareStr.Substring(8,2)) + " " + Convert.ToInt16(timeStampIntSquareStr.Substring(8,2))%23  );
                // Console.WriteLine("Test :" + timeStampIntSquareStr.Substring(9,2) + " " + Convert.ToInt16(timeStampIntSquareStr.Substring(9,2)) + " " + Convert.ToInt16(timeStampIntSquareStr.Substring(9,2))%23  );
                // Console.WriteLine("Test :" + timeStampIntSquareStr.Substring(10,2) + " " + Convert.ToInt16(timeStampIntSquareStr.Substring(10,2)) + " " + Convert.ToInt16(timeStampIntSquareStr.Substring(10,2))%23  );
                // Console.WriteLine("Test :" + timeStampIntSquareStr.Substring(11,2) + " " + Convert.ToInt16(timeStampIntSquareStr.Substring(11,2)) + " " + Convert.ToInt16(timeStampIntSquareStr.Substring(11,2))%23  );
                // Console.WriteLine("Test :" + timeStampIntSquareStr.Substring(12,2) + " " + Convert.ToInt16(timeStampIntSquareStr.Substring(12,2)) + " " + Convert.ToInt16(timeStampIntSquareStr.Substring(12,2))%23  );
                
                string codeGen = "" + metin[Convert.ToInt16(mode8)] + metin[Convert.ToInt16(mode6)] + metin[Convert.ToInt16(mode4)] + metin[Convert.ToInt16(mode2)] + metin[Convert.ToInt16(mode1)] + metin[Convert.ToInt16(mode3)] + metin[Convert.ToInt16(mode5)] + metin[Convert.ToInt16(mode7)];
                
                
                
                if(code == codeGen){
                    //Console.WriteLine("i:" + i + " date :"  + date + " Code:" + code + " CodeGen:" + codeGen + " timeStamp:" + timeStamp + " Test :" + timeStampIntSquareStr);
                    checkCode = true;
                    break;
                }
            }

            return checkCode;
        }
    }
}
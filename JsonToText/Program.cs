using JsonToText;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

// read file into a string and deserialize JSON to a type
List<ResponseModel> responseModels = JsonConvert.DeserializeObject<List<ResponseModel>>(File.ReadAllText(@"file/response.json"));

int min_x, min_y, max_x, max_y;
//int x1 = 0,x2 = 0,y1 = 0,y2 = 0;

int i = 0;
string text = "";
int tempX = 0;

foreach(ResponseModel responseModel in responseModels){

    if(i == 0)
    {
        // x1 = responseModel.boundingPoly.vertices[1].x;
        // y1 = responseModel.boundingPoly.vertices[1].y;
        // x2 = 30+responseModel.boundingPoly.vertices[1].x+(responseModel.boundingPoly.vertices[1].x-responseModel.boundingPoly.vertices[0].x);
        // y2 = responseModel.boundingPoly.vertices[2].y;
    }
    else
    {
        List<int> listX = new List<int>();
        List<int> listY = new List<int>();

        int x1 = responseModel.boundingPoly.vertices[0].x;
        int x2 = responseModel.boundingPoly.vertices[1].x;
        int x3 = responseModel.boundingPoly.vertices[2].x;
        int x4 = responseModel.boundingPoly.vertices[3].x;

        int y1 = responseModel.boundingPoly.vertices[0].y;
        int y2 = responseModel.boundingPoly.vertices[1].y;
        int y3 = responseModel.boundingPoly.vertices[2].y;
        int y4 = responseModel.boundingPoly.vertices[3].y;

        listX.Add(x1);
        listX.Add(x2);
        //listX.Add(x3);
        //listX.Add(x4);

        listY.Add(y1);
        //listY.Add(y2);
        //listY.Add(y3);
        listY.Add(y4);

        min_x = listX.Min();

        min_y = listY.Min();
        
        max_x = listX.Max();

        max_y = listY.Max();
        
        //Console.WriteLine("x1:"+x1+" x2:"+x2+" y1:"+y1+" y2:"+y2);
        //Console.WriteLine("min_x:"+min_x+" min_y:"+min_y+" max_x:"+max_x+" max_y:"+max_y);
        //Console.WriteLine(responseModel.description + " Box : [" + x1 + "," + y1 +"] [" + x2 + "," + y2 +"] [" + x3 + "," + y3 +"] [" + x4 + "," + y4 +"]");
        //Console.WriteLine(responseModel.description + " Box : [" + min_x + "," + min_y +"] [" + max_x + "," + max_y +"]");
        Console.WriteLine(responseModel.description + " Box : [" + min_x + "," + max_x + "," + min_y + "," + max_y + "]");

        // if(min_x > tempX){
        //     Console.Write(responseModel.description + " ");
        // }

        // tempX = min_x;

        

        /*if(min_x >= x1 &&  max_x <= x2 && min_y >= y1 && max_y <= y2){
            text += responseModel.description;
        }
        else{
            text += '\n';
        }*/
    }
    i++;
}
var x = "test";
//Console.WriteLine(text);
Console.ReadLine();
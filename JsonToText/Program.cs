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
int tempY = 0;

// int tempX1 = 0;
// int tempX2 = 0;
// int tempX3 = 0;
// int tempX4 = 0;

// int tempY1 = 0;
// int tempY2 = 0;
// int tempY3 = 0;
// int tempY4 = 0;

foreach(ResponseModel responseModel in responseModels){

    if(i > 0)
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
        
        //Console.WriteLine("x1 : " + x1 + " x2 : " + x2 + " x3 : " + x3 + " x4 : " + x4);
        //Console.WriteLine("y1 : " + y1 + " y2 : " + y2 + " y3 : " + y3 + " y4 : " + y4);

        //Console.WriteLine("--------------------");


        if(tempX == 0 && tempY == 0){
            Console.WriteLine(responseModel.description);
        }
        else{
            if(x1 > tempX)
            {
                Console.Write(responseModel.description + " ");
            }
            else{
                if(y4 > tempX){
                    Console.WriteLine(responseModel.description);
                }
                else{
                    Console.Write(responseModel.description + " ");
                }
            }
        }

        tempX = x1;
        tempY = y4;
    }
    i++;
}

Console.WriteLine(text);
Console.ReadLine();
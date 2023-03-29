using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class FileWriteThread
    {
        static void Main(string[] args)
        {
            //(001)Multiple File Creating using MultiThread
            //Thread th1 = new Thread(MFThread.File1);
            //Thread th2 = new Thread(MFThread.File2);

            //th1.Start();
            //th2.Start();
            MFThread.File1();//here its working without thread//and also here performing Parallelism using async and await keywords for converting our method into async method for performing asynchronously.
            MFThread.File2();

            Console.ReadLine();
        }
    }

    //(001)Multiple File Creating using MultiThread
    class MFThread
    {
        public static async void File1()
        {
            await Task.Run(() =>
            {
                string path5 = @"C:\MyFiles\myFile.txt";
                using (FileStream file = new FileStream(path5, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    string data = " My Name is Gulshan..";
                    byte[] write_data = Encoding.UTF8.GetBytes(data);
                    file.Write(write_data, 0, data.Length);
                    Console.WriteLine("File Created..");
                }
            });
        }

        public static async void File2()
        {
            await Task.Run(() =>
            {
                string path5 = @"C:\MyFiles\myFile2.txt";
                using (FileStream file = new FileStream(path5, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    string data = " My Name is Gulshan..";
                    byte[] write_data = Encoding.UTF8.GetBytes(data);
                    file.Write(write_data, 0, data.Length);
                    string data1 = " Hello, What are you doing..";
                    byte[] write_data1 = Encoding.UTF8.GetBytes(data1);
                    file.Write(write_data1, 0, data1.Length);
                    Console.WriteLine("File Created..");
                }
            });
        }
    }
}
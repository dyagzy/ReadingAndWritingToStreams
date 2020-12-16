using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutStreams
{
    public class Blog
    {
        public static void UserReg()
        {
            try
            {


                Console.WriteLine("Enter the name to save your article with");
                string saveAs = Console.ReadLine();
                var saveAsPath = @"C:\Users\DanielOyagha\Documents\DotNetClassTheBulb\DotNetAssignmentCodeFiles\ " + saveAs + ".html";

                List<string> articles = new List<string>();

                Console.WriteLine("How many paragraph is your Blog post?");
                int paragraphNum = int.Parse(Console.ReadLine());

                if (!File.Exists(saveAsPath))
                {
                    Console.WriteLine("Whats is the title of your Blog post today");
                    string title = Console.ReadLine();
                    string h1TagOpen = "<h1>";
                    string h1TagClose = "</h1>";
                    string blogTitle = String.Copy((h1TagOpen + title + h1TagClose));
                    File.AppendAllText(saveAsPath, blogTitle);


                    if (paragraphNum >= 1)
                    {

                        for (int i = 0; i < paragraphNum; i++)
                        {
                            Console.WriteLine("Enter article?");
                            string article = Console.ReadLine();
                            articles.Add(article);




                        }
                        File.AppendAllLines(saveAsPath, articles);
                    }



                }


            }
            catch (Exception)
            {

                throw;
            }
        }


        
        
        public static void ReverserPrint()
        {

            var saveAsPath = @"C:\Users\DanielOyagha\Documents\DotNetClassTheBulb\DotNetAssignmentCodeFiles\logger.txt";
            List<string> logger = new List<string>();
            try
            {

               
                for (int i = 1; i < 3; i++)
                {
                    Console.WriteLine("Please enter the complain" + " " + i);
                    string complian = Console.ReadLine();
                    logger.Add(complian);

                    
                }
                Console.WriteLine();
                Console.WriteLine();

                //To print all the list element
                for (int k = 0; k < logger.Count; k++)
                {
                    Console.WriteLine(logger[k]);
                    
                }

               

                Console.WriteLine("This is the reverse prints");

                logger.Reverse();
                foreach (var item in logger)
                {
                    Console.WriteLine(item);
                }
                File.AppendAllLines(saveAsPath, logger);

                Console.ReadLine();

            }
            catch (Exception)
            {

                throw;
            }

            File.AppendAllLines(saveAsPath, logger);

            

        }


        //for (int j = 20; j > 0; j--)
        //{
        //    Console.WriteLine(j);
        //}
        //Console.ReadLine();

        //for (int i = 0; i < logger.Count; i++)
        //{
        //    Console.WriteLine(logger[i]);
        //}

        //for (int j = logger.Count; j >= 0; j--)
        //{

        //    Console.WriteLine(logger[j]);

        //}






    }
}

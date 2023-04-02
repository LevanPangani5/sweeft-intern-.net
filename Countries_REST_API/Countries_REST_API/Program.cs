// See https://aka.ms/new-console-template for more information
using Countries_REST_API;
using Newtonsoft.Json;


string path = @"C:\Countries\";

try
{       // I think i am puting too much code in try and using but i am short on time so
        // if you want see optimazed code recruit me :) 
    using (var client = new HttpClient())
    {   
        var endpoint = new Uri("https://restcountries.com/v3.1/all");
        //gets data from endpoint
        Console.WriteLine("Strtinting to pull data from the internet !");
        var result = client.GetAsync(endpoint).Result;
        //gives us ready to use json
        var json = result.Content.ReadAsStringAsync().Result;
        //Console.WriteLine(json);
        //deserializing json
        var countries = JsonConvert.DeserializeObject<List<Country>>(json);

        if (!Directory.Exists(path))
        { // creating folder for storing country files
            Directory.CreateDirectory(path);
            Console.WriteLine("Folder  for storing countries info was created successfully ! lets continue :) ");

        }

        string tempPath = "";
        for(int i = 0; i < countries.Count; i++)
        {  //shows progress
            Console.WriteLine($"Working on it {countries.Count - i} more countries left to go ! ;) ");
            //generates file path
            tempPath = path + countries[i].Name.Official + ".txt";
            File.Create(tempPath).Close();
            //generates data that we write in a file 
            string data = $"Region - {countries[i].Region}\nSubregion - {countries[i].Subregion} \n" +
                $"Latlng - ({countries[i].Latlng[0]} , {countries[i].Latlng[1]})\nArea - {countries[i].Area}\n" +
                $"Population - {countries[i].Population}";
            //writes data in the file
         File.WriteAllTextAsync(tempPath, data);
        }
        

    }
}
catch (Exception e)
{
    Console.WriteLine("unfortunately error occured :( : ");
    Console.WriteLine(e.Message);
}


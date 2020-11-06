using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static void AssignRandom()
        {
            Random rnd = new Random();
            List<Dancer> Dancers = new List<Dancer>();

            Dancer.Add(new Dancer() { Name = "Red Dancer 1" });
            Dancer.Add(new Dancer() { Name = "Red Dancer 2" });
            Dancer.Add(new Dancer() { Name = "Red Dancer 3" });
            Dancer.Add(new Dancer() { Name = "Red Dancer 4" });
            Dancer.Add(new Dancer() { Name = "Red Dancer 5" });
            Dancer.Add(new Dancer() { Name = "Blue Dancer 1" });
            Dancer.Add(new Dancer() { Name = "Blue Dancer 2" });
            Dancer.Add(new Dancer() { Name = "Blue Dancer 3" });
            Dancer.Add(new Dancer() { Name = "Blue Dancer 4" });
            Dancer.Add(new Dancer() { Name = "Blue Dancer 5" });

            List<int> numbers = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            int counter = 0;
            while (numbers.Count>0)
            {
                var random = rnd.Next(numbers.Count);
               
                if(players.ElementAt(counter).Id== null)
                {
                    players.ElementAt(counter).Id = numbers.ElementAt(random);
                    numbers.RemoveAt(random);
                    counter++;
                }
            }
        }

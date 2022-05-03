namespace lklk
{
    public class CardReporting
    {
        private Card [] Cards;
        
         public CardReporting (Card [] Cards) // Constructor, must have same name as class
        {
            this.Cards = Cards;
        }

       
        public void PrintAllCards() // Writing out all of our cards that we created from the instnce method of CardFile 
            {
                for (int j =0; j < Card.GetCount(); j++)
                {
                    System.Console.WriteLine(Cards[j].ToString()); // since ToString is an Instance mehod without the static modifier it's called with the created object array of cards of type Card
                }

            }

        public void AverageReport() // creating our average report 
        {
            int amount = 1; // for simplicity reasons we create an amt variable for easier computing of average by manufacturer type 
            System.Console.WriteLine("Here are the Average card value by manufacturer: /n"); // intro to the method
            string thisManufacturer =  Cards[0].GetManufacturer(); // Here we are setting a string variable to the first card in our txt file or otherwise cards array so we can properly compare the next 
            double thisSum = Cards[0].GetValue(); // same thing as above but for the value of the card 
           
            for (int j = 1; j<Card.GetCount(); j++) // here we call our private variabl of count through the class method GetCount instead of declaring the count here
            {
                    if(thisManufacturer == Cards[j].GetManufacturer()) // here we are checking the current manufacturer to the next one, 
                   {
                        thisSum += Cards[j].GetValue(); // if it's true, we adjust our sum for this manufacturer by adding the value of the card j is currently on
                        amount++; // increasing the amount of cards we have read for that manufacturer 
                    }
                    else
                    {
                       
                        System.Console.WriteLine($"Cards made by {thisManufacturer} have an average value of ${thisSum/amount}"); // dislaying the average card value by manufacturer 
                        thisManufacturer = Cards[j].GetManufacturer(); //we now reset our this manufacturer string to the new manufacturer which is different that j is on
                        amount = 1; // we now reset that amount of cards read for this new manufacturer to one since the thisManufacturer variable accounts for the first one
                        thisSum = Cards[j].GetValue();// resetting the sum for this manufacturer to start as the first value of the card we have changed the thisManufacturer too
                        
                    }   
            }
            System.Console.WriteLine($"Cards made by {thisManufacturer} have an average value of ${thisSum/amount}");
            System.Console.WriteLine("Finished"); // showing the user that the program is done with the list of cards
        }

    public void CardSellReport() // this report shows the combination of any two cards worth more than ten
    {
        System.Console.WriteLine("Here are the combination of any two cards that are worth $10 or more:"); // showing the user what this method does
        for(int j = 0; j<Card.GetCount(); j++) // again we call the class method of GetCount rather than declaring a count variable. Notice that j is at zero since it will be the first card in the array that we compare with all of those below
        {

            for (int g=j+1; g<Card.GetCount(); g++) // g must be initialized as one greater than j inorder for it to always compare the previous card to the next one below it, if it we to be just the number greater than j at the start "i.e 1" it would always reinitialize as such and would compare cards that have already been read or the card that j has already accounted for 
            {
                if(Cards[j].GetValue()+Cards[g].GetValue()>=10.00) // here we are checking if the value of the two compared cards "j" and "g" values (through the get value method) sums are greater than or equal to ten
                {
                    System.Console.WriteLine($"Cards {Cards[j].GetId()} and {Cards[g].GetId()} are worth a combined ${Cards[j].GetValue()+Cards[g].GetValue()}"); //showing the user the id of the two combined cards and there value sum 
                }
            }

            
        }







    }




















    }
}
using System.IO;
namespace lklk
{
    public class CardFile
    {
        private string fileName;

           public CardFile(string fileName) //Constructor for the file being created
        {
            this.fileName = fileName;
        }

        public Card[] GetAllCards() // Instancee method 
        {
            Card.SetCount(0); //Calling the class method SetCount, notice it has the class name of Card rather than the object name we use below of cards

            Card [] Cards = new Card [10]; // creating a new card class array which we call cards, this Cards array has a size of ten, the array type is "Card' which is its own variable we have created or an object
            StreamReader inFile = new StreamReader ("card.txt"); // Reading in a file called card.txt
            string card = inFile.ReadLine(); //creating a card string for each line in the .txt file that corresponds to a specific card
            while (card != null) //as long as there is another line with info eligible to create a card
            {
            string [] temp = card.Split('#'); // # deliminator 
            Cards[Card.GetCount()] = new Card(int.Parse(temp[0]), temp [1], temp [2], double.Parse(temp[3])); // now calling that cards array we have created previously, notice that instead of a count variable we call the private class method whch retrieves it for increased security, just like we had done at the start of the methdd, also the new Card is showing we are creating a new object from the Card constructor method 
            Card.IncCount(); // calling the class method of incrementing that count 
            card = inFile.ReadLine(); // update read
            
            }
            inFile.Close(); // close file
            return Cards; // returning our cards array of our custom variable type of Card of the class
        }

        public void Save(Card[] Cards)
        {
            StreamWriter outFile = new StreamWriter ("cardtxt");
            for(int j = 0; j < Card.GetCount(); j++)
            {
                outFile.WriteLine(Cards[j].ToFile());
            }

            outFile.Close();
        }




















    }
}
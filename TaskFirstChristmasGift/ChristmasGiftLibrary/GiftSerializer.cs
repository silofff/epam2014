using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChristmasGiftLibrary
{
    public class GiftSerializer
    {
        private readonly BinaryFormatter _formatter = new BinaryFormatter();
        private FileStream _fs;
        
        public void SerializeGift(ChristmasGift gift, string giftName)
        {
            _fs = new FileStream(giftName, FileMode.Create);
            try 
            {
                _formatter.Serialize(_fs, gift);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                _fs.Close();
            }
        }

        public ChristmasGift DeserializeGift(string giftName)
        {
            _fs = new FileStream(giftName, FileMode.Open);
            ChristmasGift gift;
            try 
            {
                gift = (ChristmasGift) _formatter.Deserialize(_fs);
            }
            catch (SerializationException e) 
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally 
            {
                _fs.Close();
            }
            return gift;
        }
    }
}

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ChristmasGiftLibrary
{
    public class GiftSerializer
    {
        private readonly BinaryFormatter _formatter = new BinaryFormatter();
        private FileStream _fs;
        
        public void SerializeGift(ChristmasGift gift, string giftName)
        {
            try 
            {
                _fs = new FileStream(giftName, FileMode.Create);
                _formatter.Serialize(_fs, gift);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _fs.Close();
            }
        }

        public ChristmasGift DeserializeGift(ChristmasGift gift, string giftName)
        {
            try
            {
                _fs = new FileStream(giftName, FileMode.Open);
                gift = (ChristmasGift) _formatter.Deserialize(_fs);
            }
            catch (Exception)
            {
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

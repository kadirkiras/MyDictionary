namespace MyDictionary
{
    public class MyDicList<TKey,TVal>
    {
        private TKey[] itemNo;
        private TVal[] itemName;
        public MyDicList()
        {
            itemNo = new TKey [0];
            itemName = new TVal [0];
        }

        public void Add(TKey key, TVal val)
        {
            TKey[] tempKey = itemNo;
            TVal[] tempVal = itemName;
            
            //Key ler icin
            itemNo = new TKey[itemNo.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                itemNo[i] = tempKey[i];
            }
            
            itemNo[itemNo.Length - 1] = key;
            
            //Val ler icin
            itemName = new TVal[itemName.Length + 1];
            for (int j = 0; j < tempVal.Length; j++)
            {
                itemName[j] = tempVal[j];
            }
            
            itemName[itemName.Length - 1] = val;
        }

        public int Length
        {
            get { return itemName.Length; }
        }

       
    }
}
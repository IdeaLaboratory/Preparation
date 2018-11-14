namespace Tree
{
    /// <summary>
    /// Trie is an efficient information reTRIEval data structure
    /// 
    /// A well balanced BST will need time proportional toM * log N,
    /// where M is maximum string length and N is number of keys in tree.
    /// 
    /// Using Trie, we can search the key in O(M) time.
    /// </summary>
    public class Trie
    {
        // Alphabet size (# of symbols) 
        const int ALPHABET_SIZE = 26;

        TrieNode root;

        // trie node 
        class TrieNode
        {
            public TrieNode[] children = new TrieNode[ALPHABET_SIZE];

            // isEndOfWord is true if the node represents 
            // end of a word 
            public bool isWord;

            public TrieNode()
            {
                isWord = false;
                for (int i = 0; i < ALPHABET_SIZE; i++)
                {
                    children[i] = null;
                }
            }
        }

        public Trie()
        {
            root = new TrieNode();
        }

        public void Insert(string key)
        {
            TrieNode temp = root;
            int index = 0;
            for (int i = 0; i < key.Length; i++)
            {
                index = key[i] - 'a';
                if (temp.children[index] == null)
                {
                    temp.children[index] = new TrieNode();
                }
                temp = temp.children[index];
            }
            temp.isWord = true;
        }

        public bool Search(string key)
        {
            TrieNode temp = root;
            for (int i = 0; i < key.Length; i++)
            {
                TrieNode child = temp.children[key[i] - 'a'];
                if (child == null)
                {
                    return false;
                }
                temp = child;
            }
            return temp.isWord;

        }
    }
}

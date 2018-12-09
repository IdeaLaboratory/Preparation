using System.Collections.Generic;

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

        public List<string> Suggestions(string key)
        {
            List<string> suggestions = new List<string>();

            //reach till last character if available
            TrieNode temp = root;
            for (int i = 0; i < key.Length; i++)
            {
                TrieNode child = temp.children[key[i] - 'a'];
                if (child == null)
                {
                    return suggestions;
                }

                temp = child;
            } // temp is the last character of key in the trie

            
            SuggestionsUtil(temp, key, suggestions);

            return suggestions;
        }

        private void SuggestionsUtil(TrieNode root, string key, List<string> list)
        {
            if (IsLastChild(root))
            {
                return;
            }

            for (int i = 0; i < root.children.Length; i++)
            {
                TrieNode child = root.children[i];
                if (child != null)
                {
                    char temp = char.MinValue;
                    if (child.isWord)
                    {
                         temp = (char)('a' + i);
                        list.Add(key + temp);
                    }
                    SuggestionsUtil(child, key + temp, list);
                }
            }
        }

        private bool IsLastChild(TrieNode root)
        {
            foreach (TrieNode child in root.children)
            {
                return false;
            }
            return true;
        }
    }
}

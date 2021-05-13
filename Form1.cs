using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PracticeQuiz
{
    public partial class Form1 : Form
    {
        List<Question> questionList = new List<Question>();
        int currentIndex = 0;
        int answerIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populateMultipleChoiceQuestions();
            PickRandomQuestion();

            PopulateTFList();
            PickRandomTFQuestion();
        }



        #region FOR MULTIPLE CHOICE

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (IsAnswerCorrect())
            {
                MessageBox.Show("Answer is correct!");
                PickRandomQuestion();
            }
            else
            {
                MessageBox.Show("WRONG!!!");
                PickRandomQuestion();
            }
        }

        private void PickRandomQuestion()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;

            Random random = new Random();
            currentIndex = random.Next(questionList.Count);
            Question question = questionList[currentIndex];
            questionLabel.Text = question.question;
            radioButton1.Text = question.answerArray[0];
            radioButton2.Text = question.answerArray[1];
            radioButton3.Text = question.answerArray[2];
            radioButton4.Text = question.answerArray[3];
            radioButton5.Text = question.answerArray[4];
            answerIndex = question.correctAnswerIndex;
        }

        private bool IsAnswerCorrect()
        {
            switch(answerIndex)
            {
                case 0:
                    if (radioButton1.Checked) return true;
                    break;

                case 1:
                    if (radioButton2.Checked) return true;
                    break;

                case 2:
                    if (radioButton3.Checked) return true;
                    break;

                case 3:
                    if (radioButton4.Checked) return true;
                    break;

                case 4:
                    if (radioButton5.Checked) return true;
                    break;

                default:
                    return false;
            }
            return false;
        }

        private void populateMultipleChoiceQuestions()
        {
            questionList.Add(
                new Question(
                    "What is the complexity of the following code in terms of the length of the array?!@for(int i = 0; i < 3; i++) {!@   System.out.println( array[i] );}",
                    "O(O)", "O(1)", "O(5)", "O(n)", "Unpredictable", 1));
            questionList.Add(new Question("Which of the following algorithms is most easily expressed recursively?",
                "Linear search", "Quick Sort", "Bubble Sort", "Selection Sort", "None of the above", 1));
            questionList.Add(
                new Question("An algorithm with exponential growth would have complexity __________.",
                "O(n)", "O(log n)", "O(n^2)", "O(n^3)", "O(2^n)", 4));
            questionList.Add(
                new Question("The __________ algorithm sorts values by repeatedly comparing neighbouring elements in the list and swapping their position if they are not in order relative to each other.",
                "Insertion Sort", "Selection Sort", "Bubble Sort", "Quick Sort", "Merge Sort", 2));
            questionList.Add(
                new Question("The __________ of an algorithm shows the relationship between the size of the problem and the value we hope to optimize.",
                "Size Function", "Size Analysis", "Growth Function", "Growth Analysis", "None of the above", 2));
            questionList.Add(
                new Question("Which of the following algorithms will have the m smallest items in correct order after the mth pass has been completed?",
                "Insertion Sort", "Selection Sort", "Bubble Sort", "Quick Sort", "Merge Sort", 1));
            questionList.Add(
                new Question("A binary search has a time complexity of __________.",
                "O(1)", "O(log n)", "O(n)", "O(n log n)", "O(n^2)", 1));
            questionList.Add(
                new Question("The __________ algorithm sorts a list of values by repetitively inserting a particular value into a subset of the list that has already been sorted.",
                "Insertion Sort", "Selection Sort", "Bubble Sort", "Quick Sort", "Merge Sort", 0));
            questionList.Add(
                new Question("The time complexity of a loop is found by multiplying the time complexity of the body of the loop by __________.",
                "2", "10", "Itself", "The number of times the loop will execute", "The number of lines of code in the loop body", 3));
            questionList.Add(
                new Question("A __________ search looks through the search pool one element at a time.",
                "Binary", "Clever", "Insertion", "Selection", "Linear", 4));
            questionList.Add(
                new Question("An algorithm with complexity O(n) is said to be __________.",
                "Constant", "Linear", "Logarithmic", "Quadratic", "Exponential", 1));
            questionList.Add(
                new Question("Suppose we have five algorithms that solve a particular problem, which have the following complexities. Which one is most efficient for a large value of n?",
                "O(n)", "O(n log n)", "O(n^2)", "O(n^3)", "O(2^n)", 0));
            questionList.Add(
                new Question("In a binary search, __________.",
                "it is assumed that all of the elements are integers", "It is assument that all of the elemnts are objects", "It is assumed that the search pool is small", "it is assumed that the search pool is ordered", "It is assumed that the search pool is large", 3));
            questionList.Add(
                new Question("As the number of items in a search pool grows, the number of comparisons required to search for an item in the pool __________.",
                "Increases", "Decreases", "Stays the same", "Goes to 0", "None of the above", 0));
            questionList.Add(
                new Question("Which of the following algorithms should stop if no swaps of elements have taken place on a pass through the list?",
                "Insertion Sort", "Selection Sort", "Bubble Sort", "Quick Sort", "Merge Sort", 2));
            questionList.Add(
                new Question("Suppose we have five algorithms that solve a particular problem, which have the following complexities. Which one is least efficient for a large value of n?",
                "O(n)", "O(n log n)", "O(n^2)", "O(n^3)", "O(2^n)", 4));
            questionList.Add(
                new Question("Which of the following methods inserts an element into a stack data structure?",
                "enqueue", "dequeue", "insert", "pop", "push", 4));
            questionList.Add(
                new Question("Which of the following is not a queue operation?",
                "enque", "dequeue", "first", "isEmpty", "All of the above are vlid operations on a queue", 4));
            questionList.Add(
                new Question("The operation that does not modify a queue is __________.",
                "enqueue", "dequeue", "first", "peek", "last", 2));
            questionList.Add(
                new Question("Which of the following methods removes an element from a queue?",
                "enqueue", "dequeue", "remove", "pop", "push", 1));
            questionList.Add(
                new Question("In an ideal implementation for either a stack or a queue, all operations other than toString() are __________ .",
                "O(1)", "O(n)", "O(log n)", "O(n^2)", "It depends on the operation", 0));
            questionList.Add(
                new Question("Which of the following is not an operation on a stack?",
                "push", "pop", "peek", "poke", "All of the above are valid operations of a stack", 3));
            questionList.Add(
                new Question("What exception is thrown if the pop method is called on an empty stack?",
                "EmptyStackException", "NoSuchElementException", "ArrayOutOfBoundsException", "EmptyCollectionException", "None of the Above", 3));
            questionList.Add(
                new Question("In an array-based implementation of a queue that stores the front of the queue at index 0 in the array, the dequeue operation is __________.",
                "O(1)", "O(log n)", "O(n)", "O(n^2)", "None of the above", 2));
            questionList.Add(
            new Question("Which of the following is not a method of the Iterator interface?",
            "hasNext()", "next()", "remove()", "iterator()", "None of the above", 3));
            questionList.Add(
                new Question("Suppose you are to implement a linear search of a collection which is to stop the search and return the first object that meets the search criteria. Which of the following applies?",
                "You shoudl use a for-each loop", "You should use an explicit iterator and a while loop", "You should use an implicit itartor and a while loop", "This is not possible to do", "None of the above", 0));
            questionList.Add(
                new Question("A list collection in Java may be categorized as __________.",
                "Ordered", "Unordered", "Indexed", "Any of the above", "All of the above", 3));
            questionList.Add(
                new Question("The time complexity of the contains() operation on a LinkedList is __________.",
                "O(1)", "O(n)", "O(log n)", "O(n log n)", "O(n^2)", 1));
            questionList.Add(
                new Question("An iterator that is fail-fast will throw an exception if __________.",
                "The collection is empty", "The collection is not iterable", "The collection is modified outside the iterator while the iterator is active", "All of the above", "None of the above", 2));
            questionList.Add(
                new Question("Which of the following tree traversals traverses the subtrees from left to right and then visits the root?",
                "Preorder", "Inorder", "Postorder", "Level-Order", "None of the above", 2));
            questionList.Add(
                new Question("What property of the tree does its order specify?",
                "Maximum height", "Maximum number of leaves", "Maximum number of internal nodes", "Maximum number of edges", "Maximum number of children per node", 4));
            questionList.Add(
                new Question("One method of implementing a tree using an array involves storing the child of the element at the index n in the array at indexes __________.",
                "n + 1 and n + 2", "2^n+1 and 2^n+2", "2n+1 and 2n+2", "n-1 and n-2", "None of the above", 2));
            questionList.Add(
                new Question("A binary search tree that is highly unbalanced is called a __________ tree.",
                "Full", "Complete", "Degenerate", "Unsearchable", "None of the above", 2));
            questionList.Add(
                new Question("Which of the following best describes a balanced tree?",
                "Has all leaves at exactly the same level", "Has no leaves at exactly the same level", "Half of the leaves at one level, half at another", "all of the leaves within one level of each other", "None of the above", 3));
            questionList.Add(
                new Question("When removing an element from a binary search tree, we must always __________.",
                "Make sure that the new tree is a binary search tree", "Build a new tree", "Find its inorder successor", "Remove all of its children", "An element should never be removed from a binary search tree", 0));
            questionList.Add(
                new Question("Finding an element in a balanced binary search tree that contains n elements requires __________ comparisons.",
                "O(1)", "O(n)", "O(2n)", "O(log2n)", "None of the above", 3));
            questionList.Add(
                new Question("A full binary tree of height n has __________ leaves.",
                "n", "2n", "2^n", "2^(n+1)", "2^(n-1)", 2));
            questionList.Add(
                new Question("In a(n) __________ graph, an edge from a node labeled A to a node labeled B is the same as having an edge from B to A.",
                "Directed", "Undirected", "Sparse", "Tree-Like", "None of the above", 1));
            questionList.Add(
                new Question("In graph terminology, the nodes are referred to as __________",
                "Vertices", "Edges", "Parents", "Children", "None of the above", 0));
            questionList.Add(
                new Question("Which of the following is always true when adding an element to a heap?",
                "The new element is always a leaf", "The new element is always a root", "The new element is always an internal node", "The new element will always have two children", "None of the above", 0));
            questionList.Add(
                new Question("For a given set of elements __________.",
                "There is exactly one heap configuration", "There can be many heap configurations", "An infinite number of configurations is possible", "You can oly form a heap if all elements unique", "None of the above", 1));
            questionList.Add(
                new Question("In the __________ method, the index is formed by extracting, and then manipulating, specific digits from the key.",
                "Shift folding", "Mid-Square", "Radix Transformation", "Digit Analysis", "None of the above", 3));
            questionList.Add(
                new Question("Which of the following is always true for a priority queue?",
                "Elements are stored using a FIFO queue", "Elements are stored using a LIFO stack", "Elements must be added in priority order", "An element with the highest priority is retrieved first", "None of the above", 3));
            questionList.Add(
                new Question("The __________ method for handling collisions looks for another open position in the table other than the one to which the element is originally hashed.",
                "Open addressing", "Chaining", "Delta Hashing", "Overflow chaining", "None of the above", 0));
            questionList.Add(
                new Question("A maxheap is a complete binary tree in which each element is __________.",
                "Greater than one of its children", "Greater than or euqla to one of its children", "Greater than both of its children", "Greater than or equal to both of its children", "None of the above", 3));
        }

        #endregion

        List<TrueFalseQuestion> tfQuestionList = new List<TrueFalseQuestion>();

        private void trueFalseSubmitButton_Click(object sender, EventArgs e)
        {
            if(IsValidTFAnswer())
            {
                MessageBox.Show("You are correct!");
            }
            else
            {
                MessageBox.Show("WRONG!!");
            }
            PickRandomTFQuestion();
        }

        private void PopulateTFList()
        {
            tfQuestionList.Add(
                new TrueFalseQuestion("To represent constant time complexity, we use O(0).", false));
            tfQuestionList.Add(
                new TrueFalseQuestion("A linear search always requires more comparisons than a binary search.", false));
            tfQuestionList.Add(
                new TrueFalseQuestion("With each comparison, a binary search eliminates approximately half of the items remaining in the search pool.", true));
            tfQuestionList.Add(
                new TrueFalseQuestion("The time complexity of a method call is the same as the time complexity of the body of the method being called.", true));
            tfQuestionList.Add(
                new TrueFalseQuestion("Bubble sort is the most efficient searching algorithm.", false));
            tfQuestionList.Add(
                new TrueFalseQuestion("A Quick sort is a more efficient sorting algorithm than a Bubble sort.", true));
            tfQuestionList.Add(
                new TrueFalseQuestion("Quick sort works by separating a list into two lists, and recursively sorting the two lists using quick sort.", true));
            tfQuestionList.Add(
                new TrueFalseQuestion("Every algorithm for a problem has the same efficiency.", false));
            tfQuestionList.Add(
                new TrueFalseQuestion("It is only possible to implement a queue using an array-based structure.", false));
            tfQuestionList.Add(
                new TrueFalseQuestion("It is possible to implement a stack and a queue in such a way that all operations other than toString() take a constant amount of time.", true));
            tfQuestionList.Add(
                new TrueFalseQuestion("A stack is a LIFO structure.", true));
            tfQuestionList.Add(
                new TrueFalseQuestion("The peek operation on a stack returns a reference to the element at the bottom of the stack.", false));
            tfQuestionList.Add(
                new TrueFalseQuestion("An iterator provides a way to access multiple elements of a collection at the same time.", false));
            tfQuestionList.Add(
                new TrueFalseQuestion("A for-each loop can only be used on an Iterable collection.", true));
            tfQuestionList.Add(
                new TrueFalseQuestion("An ordered list maintains its elements according to a contiguous numeric index.", false));
            tfQuestionList.Add(
                new TrueFalseQuestion("Only Comparable objects can be stored in an ordered list.", true));
            tfQuestionList.Add(
                new TrueFalseQuestion("An iterator provides a way to access multiple elements of a collection at the same time.", false));
            tfQuestionList.Add(
                new TrueFalseQuestion("A for-each loop can only be used on an Iterable collection.", true));
            tfQuestionList.Add(
                new TrueFalseQuestion("An ordered list maintains its elements according to a contiguous numeric index.", false));
            tfQuestionList.Add(
                new TrueFalseQuestion("Only Comparable objects can be stored in an ordered list.", true));
            tfQuestionList.Add(
                new TrueFalseQuestion("In an inorder traversal, the elements of a tree are visited in order of their distance from the root.", false));
            tfQuestionList.Add(
                new TrueFalseQuestion("In a binary search tree, a new element is always initially added as a leaf.", true));
            tfQuestionList.Add(
                new TrueFalseQuestion("In a full tree, all leaves are at the same level.", false));
            tfQuestionList.Add(
                new TrueFalseQuestion("A binary search tree is always a full tree.", false));
            tfQuestionList.Add(
                new TrueFalseQuestion("When using chaining for each index, the number of items that can be stored in a hash table is limited by the size of the hash table.", false));
            tfQuestionList.Add(
                new TrueFalseQuestion("A heap sort sorts elements by constructing a heap out of them, and then removing them one at a time from the root.", true));
            tfQuestionList.Add(
                new TrueFalseQuestion("A cycle is a path that starts and ends on the same vertex without repeating any edges.", true));
            tfQuestionList.Add(
                new TrueFalseQuestion("A maxheap sort will provide a sorted list in ascending order.", false));
        }

        int currentTFIndex = 0;
        private void PickRandomTFQuestion()
        {
            trueRadioButton.Checked = false;
            falseRadioButton.Checked = false;

            Random random = new Random();
            currentTFIndex = random.Next(tfQuestionList.Count);
            TrueFalseQuestion tfQuestion = tfQuestionList[currentTFIndex];
            trueFalseQuestionLabel.Text = tfQuestion.question;
        }

        private bool IsValidTFAnswer()
        {
            bool answer = tfQuestionList[currentTFIndex].correctAnswer;

            if(trueRadioButton.Checked && answer)
            {
                //True and true, so we're right
                return true;
            }
            else if(falseRadioButton.Checked && !answer)
            {
                //False and false so we're right
                return false;
            }
            return false;
        }
    }

    class Question
    {
        public string question;
        public string[] answerArray;
        public int correctAnswerIndex;

        public Question(string q, string a1, string a2, string a3, string a4, string a5, int cI)
        {
            answerArray = new string[5];
            question = q;
            answerArray[0] = a1;
            answerArray[1] = a2;
            answerArray[2] = a3;
            answerArray[3] = a4;
            answerArray[4] = a5;
            correctAnswerIndex = cI;
        }
    }

    class TrueFalseQuestion
    {
        public string question;
        public bool correctAnswer;

        public TrueFalseQuestion(string q,bool ans)
        {
            question = q;
            correctAnswer = ans;
        }
    }
}

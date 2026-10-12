using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;

namespace Week_5_6_Lab_Activity_Bigtas
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        List<string> inventory = new List<string>();

        string[] champions =
        {
            "Aatrox", "Ahri", "Akali", "Akshan", "Alistar",
            "Amumu", "Anivia", "Annie", "Aphelios", "Ashe",
            "Aurelion Sol", "Azir", "Bard", "Bel'Veth", "Blitzcrank",
            "Brand", "Braum", "Briar", "Caitlyn", "Camille",
            "Cassiopeia", "Cho'Gath", "Corki", "Darius", "Diana",
            "Dr. Mundo", "Draven", "Ekko", "Elise", "Evelynn",
            "Ezreal", "Fiddlesticks", "Fiora", "Fizz", "Galio",
            "Gangplank", "Garen", "Gnar", "Gragas", "Graves",
            "Gwen", "Hecarim", "Heimerdinger", "Hwei", "Illaoi",
            "Irelia", "Ivern", "Janna", "Jarvan IV", "Jax",
            "Jayce", "Jhin", "Jinx", "K'Sante", "Kai'Sa",
            "Kalista", "Karma", "Karthus", "Kassadin", "Katarina",
            "Kayle", "Kayn", "Kennen", "Kha'Zix", "Kindred",
            "Kled", "Kog'Maw", "LeBlanc", "Lee Sin", "Leona",
            "Lillia", "Lissandra", "Lucian", "Lulu", "Lux",
            "Malphite", "Malzahar", "Maokai", "Master Yi", "Milio",
            "Miss Fortune", "Mordekaiser", "Morgana", "Naafiri", "Nami",
            "Nasus", "Nautilus", "Neeko", "Nidalee", "Nilah",
            "Nocturne", "Nunu & Willump", "Olaf", "Orianna", "Ornn",
            "Pantheon", "Poppy", "Pyke", "Qiyana", "Quinn",
            "Rakan", "Rammus", "Rek'Sai", "Rell", "Renata Glasc",
            "Renekton", "Rengar", "Riven", "Rumble", "Ryze",
            "Samira", "Sejuani", "Senna", "Seraphine", "Sett",
            "Shaco", "Shen", "Shyvana", "Singed", "Sion",
            "Sivir", "Skarner", "Smolder", "Sona", "Soraka",
            "Swain", "Sylas", "Syndra", "Tahm Kench", "Taliyah",
            "Talon", "Taric", "Teemo", "Thresh", "Tristana",
            "Trundle", "Tryndamere", "Twisted Fate", "Twitch", "Udyr",
            "Urgot", "Varus", "Vayne", "Veigar", "Vel'Koz",
            "Vex", "Vi", "Viego", "Viktor", "Vladimir",
            "Volibear", "Warwick", "Wukong", "Xayah", "Xerath",
            "Xin Zhao", "Yasuo", "Yone", "Yorick", "Yuumi",
            "Zac", "Zed", "Zeri", "Ziggs", "Zilean",
            "Zoe", "Zyra"
        };

        public Form1()
        {
            InitializeComponent();

            cmbCategory.Items.Add("Data");
            cmbCategory.Items.Add("Algorithm");
            cmbCategory.Items.Add("Array");
            cmbCategory.Items.Add("O(1) - Constant");
            cmbCategory.Items.Add("O(n) - Linear");
            cmbCategory.Items.Add("O(log n) - Logarithmic");
            cmbCategory.Items.Add("O(n²) - Quadratic");
            cmbCategory.Items.Add("O(2ⁿ) - Exponential");
            cmbCategory.Items.Add("LETS GAMBLE!!");

            cmbCategory.SelectedIndex = 0;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbExample.Items.Clear();

            if (cmbCategory.Text == "Data")
            {
                cmbExample.Items.Add("Student Data");
            }
            else if (cmbCategory.Text == "Algorithm")
            {
                cmbExample.Items.Add("Find Largest Number");
            }
            else if (cmbCategory.Text == "Array")
            {
                cmbExample.Items.Add("1D Array");
            }
            else if (cmbCategory.Text == "O(1) - Constant")
            {
                cmbExample.Items.Add("Access Array Position");
                cmbExample.Items.Add("Add Two Numbers");
                cmbExample.Items.Add("Get First Fruit");
            }
            else if (cmbCategory.Text == "O(n) - Linear")
            {
                cmbExample.Items.Add("Print Every Number");
                cmbExample.Items.Add("Find Carlo");
                cmbExample.Items.Add("Calculate Total");
            }
            else if (cmbCategory.Text == "O(log n) - Logarithmic")
            {
                cmbExample.Items.Add("Binary Search");
                cmbExample.Items.Add("Divide By 2");
                cmbExample.Items.Add("Guessing");
            }
            else if (cmbCategory.Text == "O(n²) - Quadratic")
            {
                cmbExample.Items.Add("Number Pairs");
                cmbExample.Items.Add("Two Loops");
                cmbExample.Items.Add("Compare Students");
                cmbExample.Items.Add("Multiplication Table");
            }
            else if (cmbCategory.Text == "O(2ⁿ) - Exponential")
            {
                cmbExample.Items.Add("Light Switches");
                cmbExample.Items.Add("Coin Toss");
                cmbExample.Items.Add("Password Choices");
                cmbExample.Items.Add("Two Choices");
            }
            else if (cmbCategory.Text == "LETS GAMBLE!!")
            {
                cmbExample.Items.Add("League Champion Gacha");
                cmbExample.Items.Add("Show Inventory");
            }

            if (cmbExample.Items.Count > 0)
            {
                cmbExample.SelectedIndex = 0;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();

            string example = cmbExample.Text;

            switch (example)
            {
                case "Student Data":
                    StudentData();
                    break;

                case "Find Largest Number":
                    FindLargest();
                    break;

                case "1D Array":
                    ArrayExample();
                    break;

                case "Access Array Position":
                    ConstantAccess();
                    break;

                case "Add Two Numbers":
                    AddNumbers();
                    break;

                case "Get First Fruit":
                    FirstFruit();
                    break;

                case "Print Every Number":
                    PrintNumbers();
                    break;

                case "Find Carlo":
                    FindCarlo();
                    break;

                case "Calculate Total":
                    CalculateTotal();
                    break;

                case "Binary Search":
                    BinarySearch();
                    break;

                case "Divide By 2":
                    DivideByTwo();
                    break;

                case "Guessing":
                    Guessing();
                    break;

                case "Number Pairs":
                    NumberPairs();
                    break;

                case "Two Loops":
                    TwoLoops();
                    break;

                case "Compare Students":
                    CompareStudents();
                    break;

                case "Multiplication Table":
                    MultiplicationTable();
                    break;

                case "Light Switches":
                    LightSwitches();
                    break;

                case "Coin Toss":
                    CoinToss();
                    break;

                case "Password Choices":
                    PasswordChoices();
                    break;

                case "Two Choices":
                    Choose(3, "");
                    lblComplexity.Text = "O(2ⁿ) - Exponential Time";
                    lblDescription.Text = "Each choice creates two more choices.";
                    break;

                case "League Champion Gacha":
                    LeagueGacha();
                    break;

                case "Show Inventory":
                    ShowInventory();
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            lblComplexity.Text = "Complexity:";
            lblDescription.Text = "Select an example and press Run.";
        }

        // DATA
        private void StudentData()
        {
            string name = "Maria";
            int age = 18;
            double grade = 92.0;
            string course = "BSIT";

            lstOutput.Items.Add("Student Name: " + name);
            lstOutput.Items.Add("Age: " + age);
            lstOutput.Items.Add("Grade: " + grade);
            lstOutput.Items.Add("Course: " + course);

            lblComplexity.Text = "Topic: Data";
            lblDescription.Text = "Data is information stored and processed by a computer.";
        }

        // ALGORITHM
        private void FindLargest()
        {
            int[] numbers = { 10, 25, 8, 40, 15 };

            int largest = numbers[0];

            foreach (int number in numbers)
            {
                if (number > largest)
                {
                    largest = number;
                }
            }

            lstOutput.Items.Add("Numbers:");
            lstOutput.Items.Add("10, 25, 8, 40, 15");
            lstOutput.Items.Add("");
            lstOutput.Items.Add("Largest Number: " + largest);

            lblComplexity.Text = "Topic: Algorithm";
            lblDescription.Text = "Check every number and keep the largest one.";
        }

        // ARRAY
        private void ArrayExample()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            for (int i = 0; i < numbers.Length; i++)
            {
                lstOutput.Items.Add(
                    "Index " + i + " = " + numbers[i]
                );
            }

            lblComplexity.Text = "Topic: One-Dimensional Array";
            lblDescription.Text = "Values are stored in one line and accessed using an index.";
        }

        // O(1)
        private void ConstantAccess()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            int answer = numbers[2];

            lstOutput.Items.Add("numbers[2] = " + answer);

            lblComplexity.Text = "O(1) - Constant Time";
            lblDescription.Text = "The computer goes directly to the requested position.";
        }

        private void AddNumbers()
        {
            int a = 10;
            int b = 20;

            int sum = a + b;

            lstOutput.Items.Add(a + " + " + b + " = " + sum);

            lblComplexity.Text = "O(1) - Constant Time";
            lblDescription.Text = "Only one fixed calculation is performed.";
        }

        private void FirstFruit()
        {
            string[] fruits =
            {
                "Apple",
                "Banana",
                "Mango"
            };

            string fruit = fruits[0];

            lstOutput.Items.Add("First Fruit: " + fruit);

            lblComplexity.Text = "O(1) - Constant Time";
            lblDescription.Text = "The first array item is accessed directly.";
        }

        // O(n)
        private void PrintNumbers()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            foreach (int number in numbers)
            {
                lstOutput.Items.Add(number);
            }

            lblComplexity.Text = "O(n) - Linear Time";
            lblDescription.Text = "More items means more work.";
        }

        private void FindCarlo()
        {
            string[] names =
            {
                "Ana",
                "Ben",
                "Carlo",
                "David"
            };

            foreach (string name in names)
            {
                lstOutput.Items.Add("Checking: " + name);

                if (name == "Carlo")
                {
                    lstOutput.Items.Add("Carlo Found!");
                    break;
                }
            }

            lblComplexity.Text = "O(n) - Linear Search";
            lblDescription.Text = "The program checks each name one by one.";
        }

        private void CalculateTotal()
        {
            int[] numbers = { 5, 10, 15 };

            int total = 0;

            foreach (int number in numbers)
            {
                total = total + number;

                lstOutput.Items.Add(
                    "Add " + number + " -> Total = " + total
                );
            }

            lstOutput.Items.Add("");
            lstOutput.Items.Add("Final Total: " + total);

            lblComplexity.Text = "O(n) - Linear Time";
            lblDescription.Text = "Every number must be processed.";
        }

        // O(log n)
        private void BinarySearch()
        {
            int[] numbers =
            {
                10, 20, 30, 40, 50, 60, 70
            };

            int target = 50;

            int left = 0;
            int right = numbers.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                lstOutput.Items.Add(
                    "Checking: " + numbers[middle]
                );

                if (numbers[middle] == target)
                {
                    lstOutput.Items.Add("Found: " + target);
                    break;
                }
                else if (numbers[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            lblComplexity.Text = "O(log n) - Binary Search";
            lblDescription.Text = "The search area is cut roughly in half each step.";
        }

        private void DivideByTwo()
        {
            int n = 16;

            lstOutput.Items.Add("Starting number: " + n);

            while (n > 1)
            {
                n = n / 2;
                lstOutput.Items.Add(n);
            }

            lblComplexity.Text = "O(log n) - Logarithmic Time";
            lblDescription.Text = "The number is repeatedly divided by 2.";
        }

        private void Guessing()
        {
            int low = 1;
            int high = 100;

            while (low <= high)
            {
                int middle = (low + high) / 2;

                lstOutput.Items.Add(
                    "Guess: " + middle
                );

                high = middle - 1;
            }

            lblComplexity.Text = "O(log n) - Guessing";
            lblDescription.Text = "Each step removes a large part of the remaining choices.";
        }

        // O(n²)
        private void NumberPairs()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    lstOutput.Items.Add(
                        numbers[i] + " " + numbers[j]
                    );
                }
            }

            lblComplexity.Text = "O(n²) - Quadratic Time";
            lblDescription.Text = "A loop runs inside another loop.";
        }

        private void TwoLoops()
        {
            int[] numbers = { 1, 2, 3 };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    lstOutput.Items.Add(
                        numbers[i] + " " + numbers[j]
                    );
                }
            }

            lblComplexity.Text = "O(n²) - Quadratic Time";
            lblDescription.Text = "Every number is paired with every number.";
        }

        private void CompareStudents()
        {
            string[] students =
            {
                "Ana",
                "Ben",
                "Carlo"
            };

            for (int i = 0; i < students.Length; i++)
            {
                for (int j = 0; j < students.Length; j++)
                {
                    lstOutput.Items.Add(
                        students[i] + " checks " + students[j]
                    );
                }
            }

            lblComplexity.Text = "O(n²) - Quadratic Time";
            lblDescription.Text = "Every student checks every student.";
        }

        private void MultiplicationTable()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    lstOutput.Items.Add(
                        i + " x " + j + " = " + (i * j)
                    );
                }
            }

            lblComplexity.Text = "O(n²) - Quadratic Time";
            lblDescription.Text = "Nested loops create n x n operations.";
        }

        // O(2^n)
        private void LightSwitches()
        {
            int n = 3;
            int combinations = 1;

            for (int i = 0; i < n; i++)
            {
                combinations = combinations * 2;
            }

            lstOutput.Items.Add("Number of switches: " + n);
            lstOutput.Items.Add("Each switch: OFF or ON");
            lstOutput.Items.Add("Possible combinations: " + combinations);

            lblComplexity.Text = "2^n Possible Combinations";
            lblDescription.Text = "Every switch has two possible choices.";
        }

        private void CoinToss()
        {
            int tosses = 5;
            int combinations = 1;

            for (int i = 0; i < tosses; i++)
            {
                combinations = combinations * 2;
            }

            lstOutput.Items.Add("Coin tosses: " + tosses);
            lstOutput.Items.Add("Each toss: Heads or Tails");
            lstOutput.Items.Add("Possible combinations: " + combinations);

            lblComplexity.Text = "2^n Possible Combinations";
            lblDescription.Text = "Every coin toss has two possible results.";
        }

        private void PasswordChoices()
        {
            int positions = 4;
            int combinations = 1;

            for (int i = 0; i < positions; i++)
            {
                combinations = combinations * 2;
            }

            lstOutput.Items.Add("Password positions: " + positions);
            lstOutput.Items.Add("Each position: A or B");
            lstOutput.Items.Add("Possible passwords: " + combinations);

            lblComplexity.Text = "2^n Possible Combinations";
            lblDescription.Text = "Each password position has two choices.";
        }

        private void Choose(int n, string result)
        {
            if (n == 0)
            {
                lstOutput.Items.Add(result);
                return;
            }

            Choose(n - 1, result + " Apple");
            Choose(n - 1, result + " Banana");
        }

        // LETS GAMBLE!!
        private async void LeagueGacha()
        {
            lstOutput.Items.Clear();

            lstOutput.ForeColor = Color.White;

            lstOutput.Items.Add("=== LETS GAMBLE!! ===");
            lstOutput.Items.Add("");
            lstOutput.Items.Add("Rolling...");

            await Task.Delay(500);

            lstOutput.Items.Add("Rolling harder...");

            await Task.Delay(500);

            lstOutput.Items.Add("Almost there...");

            await Task.Delay(500);

            string champion = champions[random.Next(champions.Length)];

            int chance = random.Next(1, 101);

            string rarity;

            if (chance <= 5)
            {
                rarity = "LEGENDARY";
                lstOutput.ForeColor = Color.Gold;
            }
            else if (chance <= 20)
            {
                rarity = "EPIC";
                lstOutput.ForeColor = Color.MediumPurple;
            }
            else if (chance <= 50)
            {
                rarity = "RARE";
                lstOutput.ForeColor = Color.DeepSkyBlue;
            }
            else
            {
                rarity = "COMMON";
                lstOutput.ForeColor = Color.White;
            }

            string result = champion + " - " + rarity;

            inventory.Add(result);

            lstOutput.Items.Clear();

            lstOutput.Items.Add("=== LETS GAMBLE!! ===");
            lstOutput.Items.Add("");
            lstOutput.Items.Add("YOU GOT:");
            lstOutput.Items.Add("");
            lstOutput.Items.Add(champion);
            lstOutput.Items.Add(rarity);
            lstOutput.Items.Add("");
            lstOutput.Items.Add("Total Champions: " + inventory.Count);

            lblComplexity.Text = "LETS GAMBLE!!";
            lblDescription.Text = "Your champion has been added to your inventory.";
        }

        private void ShowInventory()
        {
            lstOutput.Items.Add("=== YOUR INVENTORY ===");
            lstOutput.Items.Add("");

            if (inventory.Count == 0)
            {
                lstOutput.Items.Add("Inventory is empty.");
                lstOutput.Items.Add("Go gamble first.");
            }
            else
            {
                for (int i = 0; i < inventory.Count; i++)
                {
                    lstOutput.Items.Add(
                        (i + 1) + ". " + inventory[i]
                    );
                }

                lstOutput.Items.Add("");
                lstOutput.Items.Add(
                    "Total Champions: " + inventory.Count
                );
            }

            lblComplexity.Text = "LETS GAMBLE!! - Inventory";
            lblDescription.Text =
                "Shows all champions you pulled during this session.";
        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
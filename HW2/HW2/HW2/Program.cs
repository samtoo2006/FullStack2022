/* Copying an array
int[] array;
int[] newArr = new int[array.Length];
for (int i = 0; i < array.Length; i++) { 
    newArr[i] = array[i];
    Console.WriteLine($"The {i}th element of array is {array[i]}"); 
    Console.WriteLine($"The {i}th element of copied array is {newArr[i]}"); 
    Console.WriteLine(); 
}
*/

/* Manage list of elements
 List<string> list = new List<string>(); 
Console.Write("Enter command (+ item, - item or -- to clear): ");
string operation = Console.ReadLine(); while (operation != null) { 
switch (operation) { 
case "+": Console.Write("Please enter the element: "); 
list.Add(Console.ReadLine()); 
Console.WriteLine($"The current list is: "); 
foreach (var item in list) { 
Console.Write(item + "\t"); 
}
Console.WriteLine();
break; 
case "-": 
list.RemoveAt(list.Count - 1); 
Console.WriteLine($"The current list is: {list}"); 
Console.WriteLine($"The current list is: "); 
foreach (var item in list) { 
Console.Write(item + "\t"); 
}
Console.WriteLine(); break; 
case "--": list.Clear(); 
Console.WriteLine("You have removed all the elements");
break; 
default: Console.WriteLine("Invalid operation"); 
break; 
}
Console.WriteLine("Insert another input to Continue: "); 
operation = Console.ReadLine(); 
} 
}
*/

/* Reverse a string
 public string ReverseStringOne(string s) 
{ if (s == null) { 
        return string.Empty; }char[] chars = s.ToCharArray();
    for (int i = 0, j = chars.Length - 1; i < j; i++, j--)
    { 
        char c = chars[i]; chars[i] = chars[j]; chars[j] = c; 
    }
    string res = new string(chars); return res;
}
*/

/* Parse URL
 public void ParseUrl(string url) {
char[] seperator = new char[] { ':', '/', '/' }; 
int i = url.IndexOfAny(seperator); 
string protocal, secondHalf;
if (i != -1) { 
protocal = url.Substring(0, i);
secondHalf = url.Substring(i + 3); 
}
else { protocal = " "; secondHalf = url; }
string[] temp = secondHalf.Split('/'); 
string server = temp[0]; 
string resource; 
if (temp.Length > 1) { resource = temp[1]; } 
else { resource = " "; }
Console.WriteLine($"[protocal] = {protocal}"); 
Console.WriteLine($"[server] = {server}"); 
Console.WriteLine($"[resource] = {resource}"); 
}
*/
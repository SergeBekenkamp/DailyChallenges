Daily challenge from https://codefights.com/challenge/y4q97ZToigDhSPSHc

Description: 
The Ultimate Binary Challenge (UBC) is a challenge that each member of the Tumba-Yumba tribe should complete to prove that they are worthy to carry a proud name of an adult Tumba-Yumbian.

In this challenge, the contestant is given an instruction string, and their goal is to return the value encoded with it by following several rules.

As the first step, one should calculate the sum of ASCII characters of all the characters in instructions.

As the second step, the contestant should modify the value obtained during the first step according to the instructions. instructions string consists of several parts, with each part given in the format <rule><value>. The resulting value should be updated according to the rules by processing them one by one from left to right. There are several possible rules:

"" (empty rule): ignore the value and do nothing;
"&": calculate the value of bitwise and between the current result and the value and assign it to the current result;
"|": calculate the value of bitwise or between the current result and the value and assign it to the current result;
"^": same, but with bitwise XOR operation;
"<<": same, but with bitwise left shift operation;
">>": same, but with bitwise right shift operation;
"SB": set the valueth (0-based counting from right) bit of the result to 1;
"CB": set the valueth (0-based counting from right) bit of the result to 0.
Finally, as the last step, the nth bit of the result (0-based counting from right) should be reversed, where n is the length of the instructions string.

Given instructions, your task is to complete the challenge and prove that you're worthy to be a Tumba-Yumbian adult.

Example

For instructions = "SB16", the output should be
bitWork(instructions) = 65772.

The initial value obtained on the first step is 83 + 66 + 49 + 54 = 252.
The SB rule means that the 16th bit of 252 should be set to 1, so the result becomes 25210 = 111111002 => 100000000111111002 = 6578810.
Finally, the 4th bit should be reversed, so the result becomes 6578810 = 100000000111111002 => 100000000111011002 = 6577210, which is the answer.

Input/Output

[time limit] 3000ms (cs)
[input] string instructions

Instructions given as described above. It is guaranteed that the instructions are correct, i.e. contain only correct rules.

Constraints:
1 ≤ instructions.length ≤ 30.

[output] integer
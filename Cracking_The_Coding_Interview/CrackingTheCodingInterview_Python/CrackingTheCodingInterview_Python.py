import string

testString = "Does this string have all unique letters?" #not unique
testString2 = "this" # unique letters in string

def IsUnique(testString):
    ascii_letters = list(string.ascii_lowercase); 

    for letter in testString:
        if letter in ascii_letters:
            ascii_letters.remove(letter)
        else:
            return "not unique"

    return "is unique" 

print(IsUnique(testString));
print(IsUnique(testString2));
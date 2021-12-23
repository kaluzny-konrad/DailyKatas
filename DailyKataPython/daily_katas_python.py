def duplicate_count(text):
    duplicates = 0
    text = text.lower()
    full_text = text
    for case in full_text:
        text = text[1:]
        if case in text:
            duplicates += 1
        text = text.replace(case, "") 
    return duplicates

def even_or_odd(number):
    if number % 2 == 0:
        return "Even"
    else:
        return "Odd"

def median(array):
    array.sort()
    array_len = len(array)
    if array_len % 2:
        index = int(array_len / 2)
        return array[index]
    else:
        index = int(array_len / 2)
        index2 = int(array_len / 2) - 1
        return (array[index] + array[index2] / 2.0)
import numpy as np
from statistics import median

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

def median3(array):
    return np.median(array)

def median2(array):
    array.sort()
    index = int(len(array) / 2)
    if len(array) % 2 == 0:
        return (array[index] + array[index - 1]) / 2.0
    else:
        return array[index]
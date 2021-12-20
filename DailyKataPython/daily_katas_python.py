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
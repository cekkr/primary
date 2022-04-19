# primary
Primes numbers raw dictionary

This repository aims to publish standard de facto prime numbers dictionary useful and essential for every eventuality.

## Published dictionaries:
- **primary.ushort.bin**: all 6542 prime numbers in **unsigned short** (2 bytes each) for a total size of **12.7 KB**
- **primary.1m.3b.bin**: first **1 million** [2 to 15485863] prime numbers in **unsigned 3 bytes** for a total size of **2.86 MB**
- **primary.1m.int.bin**: first **1 million** [2 to 15485863] prime numbers in **signed/unsigned integer** (4 bytes each) for a total size of **3.81 MB**

## How use it
| Type  | Bytes |
|-------|-------|
| short | 2     |
| int   | 4     |
| long  | 8     |

In, for example, a integer table for getting the **nth** prime you have to multiply **nth** by 4 for getting its position in the file, requesting a 4 bytes long array.
If the dictionary has the extension n**b** it has a not standard size of **n** bytes. 

### Credits
cekkr @ MIT License


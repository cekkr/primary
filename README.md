# primary

Prime numbers raw binary dictionaries

This repository aims to publish standard de facto prime numbers dictionary useful and essential for every eventuality.

## Published dictionaries:

- **primary.ushort.bin**: **all** 6542 prime numbers in **unsigned short** (2 bytes each) for a total size of **12.7 KB**
- **primary.1M.3b.bin**: first **1 million** [2 to 15485863] prime numbers in **unsigned 3 bytes** for a total size of **2.86 MB**
- **primary.1M.int.bin**: first **1 million** [2 to 15485863] prime numbers in **signed/unsigned integer** (4 bytes each) for a total size of **3.81 MB**
- **primary.3b.bin**: **all** 1077871 prime numbers in **3 bytes** for a total size of **3.08 MB**
- **primary.2M.int.bin**: first **2 million** [2 to 32452843] prime numbers in **signed/unsigned integer** (4 bytes each) for a total size of **7.62 MB**
- **primary.10M.int.bin**: first **10 million** [2 to 179424673] prime numbers in **signed/unsigned integer** (4 bytes each) for a total size of **38.15 MB**
- **primary.20M.int.bin**: first **20 million** [2 to 373587883] prime numbers in **signed/unsigned integer** (4 bytes each) for a total size of **76.29 MB**

## How use it

| Type  | Bytes |
| ----- | ----- |
| short | 2     |
| int   | 4     |
| long  | 8     |

In, for example, a integer table for getting the **nth** prime you have to multiply **nth** by 4 for getting its position in the file, requesting a 4 bytes long array.
If the dictionary has the extension n**b** it has a not standard size of **n** bytes. 

### Credits

cekkr @ MIT License

# Airports

Да се имплементира Windows Forms апликација во која се чува листа на аеродроми. За секој аеродром се чува:
- град (string)
- име (string)
- кратенка (string)
- листа со дестинации (за секоја дестинација се чува име, оддалеченост и цена).

Треба да се имплементираат следните функционалности:
- додавање нов аеродром (клик на копчето Додади аеродром) во листата со аеродроми ListBox (20 поени)
- се отвара нова форма во која се внесуваат валидни информации (градот и името не смеат да бидат празни, а кретнката треба да биде точно 3 големи букви) за аеродромот. Валидацијата да се имплементира со ErrorProvider. (10 поени) валидација
- бришење аеродром (клик на копчето Избриши аеродром) од листата со аеродроми, со прозорец за предупредување (YES/NO) (10 поени)
- додавање нова дестинација за некој избран аеродром во листата со дестинации (клик на копчето Додади дестинација) (20 поени)
- се отвара нова форма во која се внесуваат валидни информации (името не смее да биде празно) за дестинацијата (валидација ErrorProvider) (5 поени)

Со промена на селекцијата на елемент од листата со аеродроми, се пополнува листата со дестинаци со дестинациите на избраниот аеродром (20 поени) и дополнително:
- се пресметува и прикажува просечната оддалеченост за сите дестинации на избраниот аеродром (5 поени)
- се наоѓа и прикажува дестинацијата со најголема цена (10 поени)

![main](https://github.com/user-attachments/assets/4c2e6b1c-312d-40ce-b3b4-6c41bbbbdb33)
![new_destination](https://github.com/user-attachments/assets/09b863f4-2c73-4c13-b1cb-a00eca29ebc3)
![new_airport](https://github.com/user-attachments/assets/fab9b530-b9f9-46c0-b666-5fe40f7de56d)


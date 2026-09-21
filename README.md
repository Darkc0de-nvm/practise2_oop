# C# Basics — Практична робота #2

![.NET](https://img.shields.io/badge/-10.0-512BD4?style=flat&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-13-512BD4?style=flat&logo=csharp&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=flat&logo=visualstudio&logoColor=white)

Пак консольних застосунків на C#, який включає базові алгоритмічні задачі, консольну гру та калькулятор із пріоритетом операцій.

## Проєкти

| # | Проєкт | Опис |
|---|---|---|
| 1 | [`Task1_LeapYearChecker`](./Task1_LeapYearChecker) | Визначення високосного року за введеним значенням. |
| 2 | [`Task2_NumericTriangle`](./Task2_NumericTriangle) | Генерація та вивід числової піраміди заданої висоти. |
| 3 | [`Task3_MillionaireGame`](./Task3_MillionaireGame) | Текстова вікторина «Хто хоче стати мільйонером?» із підрахунком балів. |
| 4 | [`Task4_Calculator`](./Task4_Calculator) | Калькулятор для обчислення простих математичних виразів з урахуванням пріоритету операторів. |

## Архітектура та синтаксис

> **Примітка щодо `using`:** У проєктах використовується механізм **Implicit Usings** (C# 10+ / .NET 6+). Основні простори імен (як-от `System` та `System.Collections.Generic`) підключаються автоматично на рівні конфігурації проєкту, тому врахуйте це при запуску :)

## Швидкий запуск

1. Відкрийте термінал і перейдіть у папку з проєктом `Practise2`:
   ```bash
   cd Practise2
2. Оберіть потрібний застосунок:
```bash
cd Task1_LeapYearChecker
3. Запустіть програму командою:
```bash
dotnet run
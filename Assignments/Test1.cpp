#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

//prototypes
int getValidNoPieces();
double calcBonus(int);
void printSalary(string, int, double);

const double BASE_SALARY = 1500.00;

int main() {
    string name;
    int noPieces;
    double bonus, salary;

    cout << fixed << setprecision(2);
    cout << "Enter employee name or ^z to end ";

    getline(cin, name);

    while (!cin.eof()) {
        noPieces = getValidNoPieces();
        bonus = calcBonus(noPieces);
        salary = bonus + BASE_SALARY;
        printSalary(name, noPieces, salary);
        cin.ignore(80, '\n');
        cout << "Enter employee name or ^z to end ";
        getline(cin, name);
    }
}

int getValidNoPieces() {
    int piecesAmount;
    do {
        cout << "Enter the amount of pieces the worker produced: ";
        cin >> piecesAmount;
    } while (piecesAmount < 0 || piecesAmount >= 3000);

    return piecesAmount;
}

double calcBonus(int piecesAmount) {
    if (piecesAmount < 1000) {
        return 400;
    }
    else if (piecesAmount >= 1000 && piecesAmount < 2000) {
        return 1000;
    }
    else {
        return 1500;
    }
}

void printSalary(string empName, int piecesAmount, double totalSalary) {
    cout << "Employee: " << empName << " # pieces= " << piecesAmount << "Pay is $" << totalSalary;
}
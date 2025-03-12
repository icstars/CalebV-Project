from functions.operations import addition, subtraction, multiplication, division
from functions.exp import multiple_operators
from functions.specialquit import special_quit

def main_menu():
    while True:
        print("\nMain Menu")
        print("1. Addition")
        print("2. Subtraction")
        print("3. Multiplication")
        print("4. Division")
        print("5. All Of The Above")
        print("6. Quit")
        print("7. Special Quit Dialog")

        choice = input("Select an option (1-7): ").strip()

        if not choice:
            print("I can't compute nothing, come on give me something.")
            continue

        if choice == '1':
            addition()
        elif choice == '2':
            subtraction()
        elif choice == '3':
            multiplication()
        elif choice == '4':
            division()
        elif choice == '5':
            multiple_operators()
        elif choice == '6':
            print("Goodbye!")
            break
        elif choice == '7':
            if special_quit() is False:
                continue
        else:
            print("Invalid choice. Please select a number between 1 and 7.")

if __name__ == "__main__":
    main_menu()

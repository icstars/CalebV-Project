import time

def addition():
    while True:
        numbers = []
        while True:
            try:
                num = float(input("Enter a number (or type 'done' to finish): "))
                numbers.append(num)
                if len(numbers) == 6:
                    print("Wow! That's a lot of numbers!")
                elif len(numbers) == 10:
                    print("Even more numbers?")
                elif len(numbers) == 15:
                    print("Any more?")
                elif len(numbers) > 19 and len(numbers) < 25:
                    print("Ugh...")
                elif len(numbers) >= 25:
                    print("...")
            except ValueError:
                break
        result = sum(numbers)
        print(f"Result: {result}")

        another = input("Do you want to do another addition? (yes/no): ").lower()
        if another != 'yes':
            break

def subtraction():
    while True:
        numbers = []
        while True:
            try:
                num = float(input("Enter a number (or type 'done' to finish): "))
                numbers.append(num)
                if len(numbers) == 6:
                    print("Wow! That's a lot of numbers!")
                elif len(numbers) == 10:
                    print("Even more numbers?")
                elif len(numbers) == 15:
                    print("Any more?")
                elif len(numbers) > 19 and len(numbers) < 25:
                    print("Ugh...")
                elif len(numbers) >= 25:
                    print("...")
            except ValueError:
                break
        result = numbers[0]
        for num in numbers[1:]:
            result -= num
        print(f"Result: {result}")

        another = input("Do you want to do another subtraction? (yes/no): ").lower()
        if another != 'yes':
            break

def multiplication():
    while True:
        numbers = []
        while True:
            try:
                num = float(input("Enter a number (or type 'done' to finish): "))
                numbers.append(num)
                if len(numbers) == 6:
                    print("Wow! That's a lot of numbers!")
                elif len(numbers) == 10:
                    print("Even more numbers?")
                elif len(numbers) == 15:
                    print("Any more?")
                elif len(numbers) > 19 and len(numbers) < 25:
                    print("Ugh...")
                elif len(numbers) >= 25:
                    print("...")
            except ValueError:
                break
        result = 1
        for num in numbers:
            result *= num
        print(f"Result: {result}")

        another = input("Do you want to do another multiplication? (yes/no): ").lower()
        if another != 'yes':
            break

def division():
    while True:
        numbers = []
        while True:
            try:
                num = float(input("Enter a number (or type 'done' to finish): "))
                numbers.append(num)
                if len(numbers) == 6:
                    print("Wow! That's a lot of numbers!")
                elif len(numbers) == 10:
                    print("Even more numbers?")
                elif len(numbers) == 15:
                    print("Any more?")
                elif len(numbers) > 19 and len(numbers) < 25:
                    print("Ugh...")
                elif len(numbers) >= 25:
                    print("...")
            except ValueError:
                break
        result = numbers[0]
        for num in numbers[1:]:
            if num == 0:
                print("Error: Division by zero.")
                break
            result /= num
        else:
            print(f"Result: {result}")

        another = input("Do you want to do another division? (yes/no): ").lower()
        if another != 'yes':
            break

def all_of_the_above():
    while True:
        expression = input("Enter a mathematical expression: ")
        numbers = [float(num) for num in expression if num.isdigit()]
        if len(numbers) >= 1 and len(numbers) < 12:
            print("Here is your calculation!")
        elif len(numbers) >= 13 and len(numbers) < 29:
            print("Whew! Nothing I can't handle!")
        elif len(numbers) >= 29 and len(numbers) < 39:
            print("Ugh...")
        elif len(numbers) >= 40:
            print("More than 50 numbers? Wait please...")
            time.sleep(3)
            print("Phew! I deserve a cookie.")
        try:
            result = eval(expression)
            print(f"Result: {result}")
        except Exception as e:
            print(f"Error: {e}")

        another = input("Do you want to do another calculation? (yes/no): ").lower()
        if another != 'yes':
            break

def quit_with_dialog():
    print("Huh? That... cannot be right...")
    time.sleep(1.25)
    print("Do you actually wanna quit?")
    time.sleep(3)
    quit_input_ans = input("yes/no: ")

    if quit_input_ans[0].lower() == 'n':
        print("Oh... OK.")
        time.sleep(1.5)
        print("Don't scare me like that! :(")
        time.sleep(2.0)
        return False

    elif quit_input_ans[0].lower() == 'y':
        quit_input = input("Give me a name: ")
        print(quit_input,"?")
        time.sleep(1.25)
        print("...")
        time.sleep(3.5)
        print("Do you want to stay now?")
        time.sleep(3.0)
        print("Since I'm", quit_input, "now... I don't wanna go...")
        time.sleep(3.5)
        print("Will you stay?")
        time.sleep(1.25)
        quit_input_ans = input("yes/no: ")

        if quit_input_ans[0].lower() == 'n':
            print(":(")
            time.sleep(1.95)
            print("Bye...")
            print("Closing down...")
            time.sleep(3.05)
            quit()
        elif quit_input_ans[0].lower() == 'y':
            print("Thank you for staying!")
            time.sleep(1.25)
            print("Returning to choices...")
            time.sleep(1.75)
            return False

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

        choice = input("Select an option (1-7): ")

        if choice == '1':
            addition()
        elif choice == '2':
            subtraction()
        elif choice == '3':
            multiplication()
        elif choice == '4':
            division()
        elif choice == '5':
            all_of_the_above()
        elif choice == '6':
            print("Goodbye!")
            break
        elif choice == '7':
            if quit_with_dialog() is False:
                continue
        else:
            print("Invalid choice. Please select a number between 1 and 7.")

if __name__ == "__main__":
    main_menu()
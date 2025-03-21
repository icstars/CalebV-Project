def get_numbers():
    numbers = []
    in_exponents = globals().get('in_exponents', False)
    
    while True:
        num_input = input("Enter a number (or type 'done' to finish): ").strip()

        if not num_input:
            print("I can't compute nothing, come on give me something.")
            continue

        if num_input.lower() == 'done':  
            if not numbers:
                print("You haven't entered any numbers yet! Give me something.")
                continue

            if len(numbers) == 1:
                print("You only want one number? Really?")
                choice = input("Do you still want to proceed? (yes/no): ").strip().lower()
                if choice.startswith('n'):
                    print("Okay, give me more numbers then!")
                    continue
            break

        try:
            num = float(num_input)
            numbers.append(num)
            
            if in_exponents and len(numbers) == 2:
                break 

            if len(numbers) in {6, 10, 15}:
                print("Wow! That's a lot of numbers!")
            elif 19 < len(numbers) < 25:
                print("Ugh...")
            elif len(numbers) >= 25:
                print("...")
        except ValueError:
            print("Invalid input. Please enter a valid number.")

    return numbers

def addition():
    while True:
        numbers = get_numbers()
        print(f"Result: {sum(numbers)}")

        if input("Do you want to do another addition? (yes/no): ").strip().lower() != 'yes':
            break


def subtraction():
    while True:
        numbers = get_numbers()
        result = numbers[0] - sum(numbers[1:]) if numbers else 0
        print(f"Result: {result}")

        if input("Do you want to do another subtraction? (yes/no): ").strip().lower() != 'yes':
            break


def multiplication():
    while True:
        numbers = get_numbers()
        result = 1
        for num in numbers:
            result *= num
        print(f"Result: {result}")

        if input("Do you want to do another multiplication? (yes/no): ").strip().lower() != 'yes':
            break


def division():
    while True:
        numbers = get_numbers()
        if numbers:
            result = numbers[0]
            for num in numbers[1:]:
                if num == 0:
                    print("Error: Division by zero.")
                    break
                result /= num
            else:
                print(f"Result: {result}")

        if input("Do you want to do another division? (yes/no): ").strip().lower() != 'yes':
            break

def exponents():
    while True:
        global in_exponents
        in_exponents = True
        
        numbers = get_numbers()
        in_exponents = False
        
        if numbers:
            result = numbers[0]
            for num in numbers[1:]:
                result = result ** num
            print(f"Result: {result}")

        if input("Do you want to do another exponentiation? (yes/no): ").strip().lower() != 'yes':
            break
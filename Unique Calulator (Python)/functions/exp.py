import time

def multiple_operators():
    while True:
        expression = input("Enter a mathematical expression: ").strip()

        if not expression:  # Prevents empty input
            print("I can't compute nothing, come on give me something.")
            continue  # Ask again

        try:
            result = eval(expression)
            print(f"Result: {result}")
        except Exception as e:
            print(f"Error: {e}")

        if input("Do you want to do another calculation? (yes/no): ").strip().lower() != 'yes':
            break

import tkinter as tk
import os

from PIL import Image, ImageTk

def open_retroarch():
    retroarch_path = r".\RetroArch\RetroArch\RetroArch-Win64\retroarch.exe"
    
    full_path = os.path.abspath(retroarch_path)
    print(f"Trying to open: {full_path}")

    try:
        if os.path.exists(full_path):
            os.startfile(full_path)
        else:
            print("Retroarch executable not found.")
    except Exception as e:
        print(f"Error launching RetroArch: {e}")

root = tk.Tk()
root.title("Emulator Selector v0.01")
root.geometry("800x400")

tk.Label(root, text="Select an Emulator", font=("Arial", 12)).pack(pady=10)

image_path = "retroarch_icon.png"
if os.path.exists(image_path):  
    image = Image.open(image_path).resize((128, 128))
    icon = ImageTk.PhotoImage(image)
else:
    print("Warning: Image file not found!")
    icon = None

retroarch_button = tk.Button(root, text="RetroArch", command=open_retroarch, width=20, compound="left")

if icon:
    retroarch_button.config(image=icon)

retroarch_button.pack(pady=5)

root.mainloop()

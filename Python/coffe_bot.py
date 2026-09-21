import os
from telegram import Update
from telegram.constants import ParseMode
from telegram.ext import (
    ApplicationBuilder,
    CommandHandler,
    ContextTypes,
    MessageHandler,
    filters,
)

import os  # Put this at the very top (line 1)
BOT_TOKEN = ("8882834954:AAG4oo6Vwje4WXlG6wWEj64xPhVLymcLoFw")


class Drink:
    """Represents an everyday cafe drink."""

    def __init__(
        self,
        name: str,
        category: str,
        price: float,
        ingredients: list[str],
        caffeine_level: str,
        description: str,
    ):
        self.name = name
        self.category = category
        self.price = price
        self.ingredients = ingredients
        self.caffeine_level = caffeine_level
        self.description = description

    def to_message(self) -> str:
        recipe = ", ".join(self.ingredients)
        return (
            f"☕ *{self.name}*\n"
            f"🏷 *Category:* {self.category}\n"
            f"💵 *Price:* ${self.price:.2f}\n"
            f"⚡ *Caffeine:* {self.caffeine_level}\n"
            f"🥛 *Ingredients:* {recipe}\n\n"
            f"📝 *About:* _{self.description}_"
        )


# Everyday drink catalog
MENU: dict[str, Drink] = {
    "latte": Drink(
        name="Vanilla Latte",
        category="Espresso & Milk",
        price=3.25,
        ingredients=["Espresso", "Steamed Whole Milk", "Vanilla Syrup"],
        caffeine_level="Medium (~75mg)",
        description="Smooth and creamy with a mellow sweet finish.",
    ),
    "americano": Drink(
        name="Iced Americano",
        category="Espresso",
        price=2.50,
        ingredients=["Double Espresso", "Cold Filtered Water", "Ice"],
        caffeine_level="High (~150mg)",
        description="Bold and refreshing without any added sugar or milk.",
    ),
    "matcha": Drink(
        name="Iced Matcha Latte",
        category="Tea",
        price=3.75,
        ingredients=["Ceremonial Matcha", "Oat Milk", "Honey"],
        caffeine_level="Medium (~40mg)",
        description="Earthy green tea balanced with velvety oat milk.",
    ),
    "cappuccino": Drink(
        name="Classic Cappuccino",
        category="Espresso & Milk",
        price=3.00,
        ingredients=["Espresso", "Steamed Milk", "Thick Milk Foam"],
        caffeine_level="Medium (~75mg)",
        description="Equal parts rich espresso, steamed milk, and airy foam.",
    ),
    "coldbrew": Drink(
        name="Nitro Cold Brew",
        category="Cold Brew",
        price=4.00,
        ingredients=["Slow-Steeped Cold Brew", "Nitrogen Infusion"],
        caffeine_level="Very High (~200mg)",
        description="Poured cold from a tap with a naturally silky texture.",
    ),
}


async def start_command(update: Update, context: ContextTypes.DEFAULT_TYPE):
    """Greets the customer and shows the menu options."""
    if not update.message:
        return

    items = ", ".join([f"`{item}`" for item in sorted(MENU.keys())])
    welcome = (
        "👋 *Welcome to the Digital Cafe Bot!*\n\n"
        "Send me the name of any beverage to check ingredients, price, and caffeine content.\n\n"
        f"📋 *Available Drinks:*\n{items}\n\n"
        "💡 *Try sending:* `latte` or `matcha`"
    )
    await update.message.reply_text(welcome, parse_mode=ParseMode.MARKDOWN)


async def reply_drink_info(update: Update, context: ContextTypes.DEFAULT_TYPE):
    """Looks up the drink in the dictionary."""
    if not update.message or not update.message.text:
        return

    query = update.message.text.strip().lower().replace(" ", "")
    drink = MENU.get(query)

    if drink:
        await update.message.reply_text(drink.to_message(), parse_mode=ParseMode.MARKDOWN)
    else:
        items = ", ".join([f"`{item}`" for item in sorted(MENU.keys())])
        error_msg = (
            f"❌ We don't have *'{update.message.text}'* on the menu today.\n\n"
            f"📋 *Available choices:*\n{items}\n\n"
            "Send `/start` to see the full welcome message."
        )
        await update.message.reply_text(error_msg, parse_mode=ParseMode.MARKDOWN)


if __name__ == "__main__":
    if not BOT_TOKEN or BOT_TOKEN == "your-bot-token-here":
        raise ValueError("Please provide a valid bot token in BOT_TOKEN or Secrets.")

    app = ApplicationBuilder().token(BOT_TOKEN).build()

    # Handlers
    app.add_handler(CommandHandler(["start", "help", "menu"], start_command))
    app.add_handler(MessageHandler(filters.TEXT & ~filters.COMMAND, reply_drink_info))

    print("☕ Cafe Bot is running and ready for orders...")
    app.run_polling()
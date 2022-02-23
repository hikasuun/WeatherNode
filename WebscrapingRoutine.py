# WebscrapingRoutine.py
# Language: Python 3.0
# This script runs a web scrapper that scraps the 
# information from weather website and returns it
# January 2022 - 

# using beautiful soup for webscraping
from bs4 import BeautifulSoup

# URL to scrape from
# www.freeweather.com/cgi-bin/weather/weather.cgi?place=EL+PASO&state=tx

# all requests start with this beginning section of URL
# www.freeweather.com/cgi-bin/weather/weather.cgi?place=

# city is in format: CITY EX: SAN+ANTONIO / SEATTLE
# state is in format: &state=xx


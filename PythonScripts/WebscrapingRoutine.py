# WebscrapingRoutine.py
# Language: Python 3.0
# This script runs a web scrapper returns
# current weather information from requested URL
# January 2022 - 
from bs4 import BeautifulSoup
import requests

# TODO : CHANGE TO USER INPUTTED URL RATHER THAN PREDEFINED
# url to scrape weather data from
url_beg = 'https://www.freeweather.com/cgi-bin/weather/weather.cgi?place='
url_city = 'SAN+ANTONIO'
url_state = '&state=tx'
url = url_beg + url_city + url_state

# employ beautifulsoup to scrape data
page = requests.get(url)
soup = BeautifulSoup(page.content, "html.parser")

# get current weather container
weather = soup.find('div', class_='shadetabs3')
# find all the weather fields within the container
weather_elements = weather.find_all("div", class_="bottomline")

with open('PythonScripts/htmlparse.txt', 'w') as file:
    x = 0
    # write container that has location name
    file.write(weather.find('div', class_='fptitle2').text.strip()+'\n')
    # write weather information to file
    for weather_elements in weather_elements:
        file.write(weather_elements.text.strip())
        # used for formatting text file
        x += 1
        if x % 2 == 0:
            file.write('\n')
            x = 0
    # save URL to file
    file.write('URL:'+ url + '\n')
    file.close()
    
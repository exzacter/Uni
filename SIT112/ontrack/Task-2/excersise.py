# Import the pandas library and alias it as "pd"
import pandas as pd

# Read the avocado csv file, and store it in a variable that is called "data"
data = pd.read_csv('resources/avocado.csv')

# Display type, memory consumption and null count information using the info() method
data.info()

# Display the number of unqie values in each column 
data.nunique()
# dtypes: float64(9), int64(2), object(3)

# Display all the rows of data that JupyterLab (alacritty terminal) displays by default:
print(data)
#       Unnamed: 0        Date  ...  year            region
#0               0  2015-12-27  ...  2015            Albany
#1               1  2015-12-20  ...  2015            Albany
#2               2  2015-12-13  ...  2015            Albany
#3               3  2015-12-06  ...  2015            Albany
#4               4  2015-11-29  ...  2015            Albany
#...           ...         ...  ...   ...               ...
#18244           7  2018-02-04  ...  2018  WestTexNewMexico
#18245           8  2018-01-28  ...  2018  WestTexNewMexico
#18246           9  2018-01-21  ...  2018  WestTexNewMexico
#18247          10  2018-01-14  ...  2018  WestTexNewMexico
#18248          11  2018-01-07  ...  2018  WestTexNewMexico
#
#[18249 rows x 14 columns]

# Display the first and last 5 rows of data and the first and last four columns of data
with pd.option_context(
    'display.max_rows', 10, 
    'display.max_columns', 8
    ):
    pass

# Choose any 3 columns and acces it with bracket notation and display "first 5 rows" = head()
# choose 3 columns inside the data variable that holds the DF, then display first 5 rows = head. why does '[[]]' enter the data string?
# [[]] = accesses nulitple columns and returns a DF
# [] = accesses a single column and returns a SERIES
print(data[['Date', 'year', 'region']].head())

# Select one column and access it with dot notation
# so data.<colname>
# then print(data.<colname>)
# This works cause you can call your DF from the DF variable by using dot notation
data.region
print(data.region)

# Multiply the total volume and averageprice columns, and store the result ina  new col called estimatedrevenue then display the frst five rows of this data to confirm that the column was added and has the correct values
# S1 - mulitply 2 cols = data[<colname>] * data['<colname>']
# S2 - output to new col
# S3 - add to DF or integrate in S2? = data[<newcolname>] = <outputted multiplaction variable colname>
# S4 - print(data.head())
EstimatedRevenue = data['Total Volume'] * data['AveragePrice']
print(EstimatedRevenue)

data['EstimatedRevenue'] = EstimatedRevenue

print(data.head())

# Create a DataFrame that is grouped by region and type and that includes the average price for the grouped columns, then reset the index and "display the first five rows" = head()
# grouped by region and type and that includes the average price 

grouped_data = data.groupby(['region', 'type'])[['AveragePrice']].mean()

print(grouped_data)

grouped_data.reset_index(inplace=True)

print(grouped_data)

#Create a bar plot, that shows the mean, median and standard deviation of the total volume per year

# what does bar plot - then how do we pass in to do mean median and standard deviation
# Could we just do groupby?


plot = data.groupby(['year'])[['Total Volume']].agg(['mean', 'median', 'std'])

plot_fig = plot.plot.bar(rot=0)

# printing to image

# plot_fig.get_figure().savefig('P2_Excersie_Bar_Plot.png')

# How many unique regions are there?
# nunique for unique values, wonder if there is a filter?

print(data['region'].nunique())

# Find the average price of a avocado from each region, show only type and average price col in output
# My answer

average_avocado_regional = data[['type', 'AveragePrice']].groupby(['type']).mean()

average_avocado_regional.reset_index(inplace=True)

print(average_avocado_regional)

# Which region has the lowest price for each type of avocado (O or C)? be sure to include just the type and average price cols in output

min_price = data.groupby(['region', 'type'])['AveragePrice'].min()
#min_price = data.groupby(['region', 'type', 'AveragePrice'])[['AveragePrice']].min()
print(min_price)

# question asked for lowest average 

min_avg_price = data.groupby(['region', 'type'])[['AveragePrice']].mean()
min_avg_price.reset_index(inplace=True)

#min_avg_price.sort_values(by=['AveragePrice']).head(3)

sorted_min_avg_price = min_avg_price.pivot(index='region', columns='type', values='AveragePrice').sort_values('organic').head(5)
print(sorted_min_avg_price)

# Have the total bags sold per year of each type of avocado become more or less consistent over time?

# std over the years, less std over the years means more consistent sales higher means less consistent 
# mean per year or max? could do both # stdfig = tbstd.plot.bar(rot=0)

# stdfig.get_figure().savefig('P2_Excersie_Bar_Plot_std_fig.png')

#data.groupby(['year'])[['']].std()
# oh wait it only cares about consistency not about how many bags have actually been sold

# group by year, then just .std()?
# no - because tehre is 3 columns small bags, large bags and xl bags, which means ill need to get the sum of those per row then std that by the year

data['TotalBags'] = data['Small Bags'] + data['Large Bags'] + data['XLarge Bags']

tbstd = data.groupby(['type', 'year'])[['TotalBags']].std()

print(tbstd)



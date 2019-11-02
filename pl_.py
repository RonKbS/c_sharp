import plotly.graph_objects as go

fig = go.Figure(
    data=go.Bar(y=[2, 3, 1])
)
fig.write_html('first_figure.html', auto_open=True)

# this produces an html file of 3mbs. wow
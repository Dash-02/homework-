import { NavigationContainer } from '@react-navigation/native'
import { createNativeStackNavigator } from '@react-navigation/native-stack'
import { Button } from '@rneui/themed'
import * as React from 'react'
import { Text, View } from 'react-native'

function HomeScreen({ navigation }) {
	return (
		<View style={{ flex: 1, alignItems: 'center', justifyContent: 'center' }}>
			<Text style={{ fontSize: 18, fontWeight: 700 }}>Главный экран</Text>
			<Button
				buttonStyle={{
					margin: 10,
				}}
				title='Перейти на вторую страницу'
				onPress={() => navigation.navigate('Details')}
			/>
			<Button
				title='Перейти на третью страницу'
				onPress={() => navigation.navigate('Details_2')}
			/>
		</View>
	)
}

function DetailsScreen({ navigation }) {
	return (
		<View
			style={{
				flex: 1,
				alignItems: 'center',
				justifyContent: 'center',
				backgroundColor: '#9ea4ca',
			}}
		>
			<Text>Вторая страница</Text>

			<Button
				buttonStyle={{
					margin: 10,
					backgroundColor: 'red',
				}}
				title='Вернуться на главную'
				onPress={() => navigation.navigate('Home')}
			/>
			<Button
				buttonStyle={{
					margin: 10,
					backgroundColor: 'blue',
				}}
				title='Перейти на третью страницу'
				onPress={() => navigation.navigate('Details_2')}
			/>
			<Button title='Вернуться назад' onPress={() => navigation.goBack()} />
		</View>
	)
}
function DetailsScreen2({ navigation }) {
	return (
		<View
			style={{
				flex: 1,
				alignItems: 'center',
				justifyContent: 'center',
				backgroundColor: '#c89eca',
			}}
		>
			<Text>Третья страница</Text>
			<Button
				buttonStyle={{ margin: 10, backgroundColor: 'red' }}
				title='Вернуться на главную'
				onPress={() => navigation.navigate('Home')}
			/>

			<Button
				title='Вернуться назад'
				buttonStyle={{ margin: 10 }}
				onPress={() => navigation.goBack()}
			/>
		</View>
	)
}
const Stack = createNativeStackNavigator()

function App() {
	return (
		<NavigationContainer>
			<Stack.Navigator initialRouteName='Home'>
				<Stack.Screen name='Home' component={HomeScreen} />
				<Stack.Screen name='Details' component={DetailsScreen} />
				<Stack.Screen name='Details_2' component={DetailsScreen2} />
			</Stack.Navigator>
		</NavigationContainer>
	)
}

export default App

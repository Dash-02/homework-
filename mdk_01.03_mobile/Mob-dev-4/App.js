import { useState } from 'react'
import {
	Alert,
	BackHandler,
	Button,
	StyleSheet,
	Text,
	View,
} from 'react-native'

export default function App() {
	const [check, isChecker] = useState(false)
	const [thousand, setThousand] = useState(1000)
	const isExit = () => {
		Alert.alert('Вы вышли из приложения')
		setTimeout(() => {
			BackHandler.exitApp()
		}, 1000)
	}
	const ThousandUI = ({ thousand }) => {
		return <Text>{thousand}</Text>
	}
	const isStart = () => {
		Alert.alert('Приложение стартануло')
		isChecker(true)
	}
	const isStop = () => {
		Alert.alert('Приложение остановилось')
		isChecker(false)
	}
	const isDestroy = () => {
		Alert.alert('Приложение обнулилось')
		setThousand(1000)
	}
	const Counter = () => {
		if (check == true) {
			setThousand(thousand - 7)
		}
	}
	return (
		<View style={styles.container}>
			<Text style={styles.items}>Amet & Dasha are developers!</Text>
			<Button style={styles.items} title='START' onPress={() => isStart()} />
			<Button style={styles.items} title='Count' onPress={() => Counter()} />
			<Button style={styles.items} title={'STOP'} onPress={() => isStop()} />
			<Button
				style={styles.items}
				title={'Destroy'}
				onPress={() => isDestroy()}
			/>
			<Button style={styles.items} title='EXIT' onPress={() => isExit()} />
			<ThousandUI thousand={thousand} />
		</View>
	)
}

const styles = StyleSheet.create({
	container: {
		padding: 10,
		flex: 1,
		backgroundColor: '#fff',
		alignItems: 'center',
		justifyContent: 'center',
	},
	items: {
		margin: 10,
		backgroundColor: 'red',
		color: '#fff',
		fontSize: 20, // added fontSize style
		fontWeight: 'bold', // added fontWeight style
		borderRadius: 10, // added borderRadius style
		padding: 10, // added padding style
	},
})

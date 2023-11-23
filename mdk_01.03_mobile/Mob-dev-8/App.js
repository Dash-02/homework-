import { Button } from '@rneui/themed'
import { useState } from 'react'
import { Alert, BackHandler, StyleSheet, Text, View } from 'react-native'
import { TextInput } from 'react-native-paper'
export default function App() {
	const [number, onChangeNumber] = useState(0)
	const [numberTwo, onChangeNumberTwo] = useState(0)
	const [allNumber, onAllNumber] = useState(0)

	return (
		<View
			style={{
				flex: 1,

				backgroundColor: '#fff',
				alignItems: 'center',
				justifyContent: 'center',
			}}
		>
			<Text style={{ color: '#000', fontSize: 24, marginTop: 250 }}>
				Калькулятор
			</Text>
			<TextInput
				style={{ width: 210, marginTop: 10 }}
				onChangeText={number => {
					onChangeNumber(Number(number))
					console.log(number)
				}}
				value={number}
				placeholder='Введите первое число'
				keyboardType='numeric'
			/>
			<TextInput
				style={{ width: 210, marginTop: 10 }}
				onChangeText={numberTwo => {
					onChangeNumberTwo(Number(numberTwo))
					console.log(numberTwo)
				}}
				value={numberTwo}
				placeholder='Введите второе число'
				keyboardType='numeric'
			/>

			<View style={{ display: 'flex', flexDirection: 'row', marginTop: 10 }}>
				<Button
					buttonStyle={{
						marginRight: 10,
					}}
					titleStyle={{ fontSize: 22 }}
					title='+'
					onPress={() => {
						onAllNumber(Number(number) + Number(numberTwo))
					}}
				/>
				<Button
					buttonStyle={{
						marginRight: 10,
					}}
					titleStyle={{ fontSize: 22 }}
					title='-'
					onPress={() => {
						onAllNumber(Number(number) - Number(numberTwo))
					}}
				/>
				<Button
					buttonStyle={{
						marginRight: 10,
					}}
					titleStyle={{ fontSize: 22 }}
					title='/'
					onPress={() => {
						onAllNumber(Number(number) / Number(numberTwo))
					}}
				/>
				<Button
					titleStyle={{ fontSize: 22 }}
					title='*'
					onPress={() => {
						onAllNumber(Number(number) * Number(numberTwo))
					}}
				/>
			</View>
			<Text style={{ fontSize: 24 }}>
				{'\n'}Ваш результат: {allNumber}
			</Text>
			<View
				style={{
					display: 'flex',
					flexDirection: 'row-reverse',
					marginTop: '30%',
					marginRight: '30%',
				}}
			>
				<Button
					buttonStyle={{
						marginLeft: 10,
					}}
					title={'ВЫЙТИ'}
					onPress={() => {
						Alert.alert('Предупреждение', 'Вы действительно хотите выйти?', [
							{
								text: 'Нет',
								onPress: () => console.log('Cancel Pressed'),
								style: 'cancel',
							},
							{ text: 'ВЫЙТИ', onPress: () => BackHandler.exitApp() },
						])
					}}
				/>
				<Button
					buttonStyle={{
						marginRight: 10,
					}}
					title='ИНСТРУКЦИЯ'
					onPress={() => {
						Alert.alert(
							'ИНСТРУКЦИЯ',
							'Данный калькулятор поможет вам в арифметических операциях таких как: сложение, вычитание, деление, умножение.'
						)
					}}
				/>
			</View>
		</View>
	)
}
const styles = StyleSheet.create({
	container: {
		flex: 1,
		marginTop: 100,
		backgroundColor: '#fff',
		alignItems: 'center',
		justifyContent: 'center',
	},
	btn: {
		padding: 10,
	},
	txt: {
		fontSize: 16,
		color: 'blue',
	},
})

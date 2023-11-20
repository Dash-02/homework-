import { Button } from '@rneui/themed'
import { StyleSheet, Text, View } from 'react-native'
export default function App() {
	return (
		<View style={styles.container}>
			<Text>ИСП Амет и Даша - Построение интерфейса</Text>
			<View style={styles.containerHorizontal}>
				<Text style={styles.HorizText}>Горизонтальный вывод элементов</Text>
				<Button
					buttonStyle={{
						borderColor: 'transparent',
						borderWidth: 0,
						borderRadius: 30,
					}}
					color='purple'
					containerStyle={{ margin: 5 }}
					title='Button'
					style={styles.ButtonHoriz}
				/>
				<Button
					buttonStyle={{
						borderColor: 'transparent',
						borderWidth: 0,
						borderRadius: 30,
					}}
					color='purple'
					containerStyle={{ margin: 5 }}
					title='Button'
					style={styles.ButtonHoriz}
				/>
				<Button
					buttonStyle={{
						borderColor: 'transparent',
						borderWidth: 0,
						borderRadius: 30,
					}}
					color='purple'
					containerStyle={{ margin: 5 }}
					title='Button'
					style={styles.ButtonHoriz}
				/>
			</View>
			<View>
				<Text>Вертикальный вывод элементов</Text>
				<Button
					buttonStyle={{
						borderColor: 'transparent',
						borderWidth: 0,
						borderRadius: 30,
					}}
					color='purple'
					containerStyle={{ margin: 5 }}
					title='Button'
				/>
				<Button
					buttonStyle={{
						borderColor: 'transparent',
						borderWidth: 0,
						borderRadius: 30,
					}}
					color='purple'
					containerStyle={{ margin: 5 }}
					title='Button'
				/>
			</View>
		</View>
	)
}

const styles = StyleSheet.create({
	container: {
		flex: 1,
		backgroundColor: '#fff',
		alignItems: 'center',
		justifyContent: 'center',
	},
	text: {
		fontSize: 14,
		lineHeight: 21,
		fontWeight: 'bold',
		letterSpacing: 0.25,
		color: 'white',
	},
	containerHorizontal: {
		flexDirection: 'row',
		height: 'auto',
	},
	HorizText: {
		flex: 1,
		flexDirection: 'column',
		marginBottom: 10,
	},
})

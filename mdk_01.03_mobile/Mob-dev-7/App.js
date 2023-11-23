import * as ScreenOrientation from 'expo-screen-orientation'
import { StatusBar } from 'expo-status-bar'
import { useEffect, useState } from 'react'
import {
	Alert,
	Image,
	ScrollView,
	StyleSheet,
	Text,
	TouchableOpacity,
	View,
} from 'react-native'
export default function App() {
	const [orientation, setOrientation] = useState(null)
	useEffect(() => {
		checkOrientation()
		const subscription = ScreenOrientation.addOrientationChangeListener(
			handleOrientationChange
		)
		return () => {
			ScreenOrientation.removeOrientationChangeListeners(subscription)
		}
	}, [])
	const checkOrientation = async () => {
		const orientation = await ScreenOrientation.getOrientationAsync()
		setOrientation(orientation)
	}
	const changeOrientation = async newOrientation => {
		console.log('newOrientation: ', newOrientation)
		await ScreenOrientation.lockAsync(newOrientation)
	}
	const handleOrientationChange = o => {
		setOrientation(o.orientationInfo.orientation)
	}
	const data = [
		{
			uri: 'https://img.icons8.com/color/48/azerbaijan.png',
			name: 'Азербайджан',
			smallname: 'Баку',
		},
		{
			uri: 'https://img.icons8.com/color/48/turkey.png',
			name: 'Турция',
			smallname: 'Анкара',
		},
		{
			uri: 'https://img.icons8.com/color/48/poland.png',
			name: 'Польша',
			smallname: 'Варшава',
		},
		{
			uri: 'https://img.icons8.com/color/48/egypt.png',
			name: 'Египет',
			smallname: 'Каир',
		},
		{
			uri: 'https://img.icons8.com/color/48/indonesia.png',
			name: 'Индонезия',
			smallname: 'Джакарта',
		},
		{
			uri: 'https://img.icons8.com/color/48/japan.png',
			name: 'Япония',
			smallname: 'Токио',
		},
	]
	console.log(orientation)
	return (
		<ScrollView>
			<View style={styles.container}>
				<View style={styles.container}>
					{data.map(el => {
						return (
							<TouchableOpacity
								onPress={() => Alert.alert(`Вы выбрали пункт ${el.name} `)}
								key={el.name}
								style={{
									display: 'flex',
									flexDirection: 'row',
									marginTop: 35,
									backgroundColor: '#808080',
								}}
							>
								<Image
									source={{ uri: el.uri }}
									style={{ width: 64, height: 64 }}
								/>
								<View style={{ display: 'flex', flexDirection: 'column' }}>
									<Text style={{ fontSize: 24 }}>{el.name}</Text>
									<Text style={{ fontSize: 16 }}>{el.smallname}</Text>
								</View>
							</TouchableOpacity>
						)
					})}
				</View>
				<Text>ORIENTATION: {orientation}</Text>
				<TouchableOpacity
					style={[styles.btn, { marginTop: 15 }]}
					onPress={() =>
						changeOrientation(ScreenOrientation.OrientationLock.PORTRAIT_UP)
					}
				>
					<Text style={styles.txt}>Tap to Portrait orientation</Text>
				</TouchableOpacity>
				<TouchableOpacity
					style={styles.btn}
					onPress={() =>
						changeOrientation(ScreenOrientation.OrientationLock.LANDSCAPE_RIGHT)
					}
				>
					<Text style={styles.txt}>Tap to Landscape orientation</Text>
				</TouchableOpacity>
				<StatusBar style='auto' />
			</View>
		</ScrollView>
	)
}
const styles = StyleSheet.create({
	container: {
		flex: 1,
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

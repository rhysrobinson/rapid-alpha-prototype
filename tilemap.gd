extends TileMap

func _input(event: InputEvent) -> void:
	var tile = world_to_map(get_global_mouse_position())
	var cell = get_cell(tile.x, tile.y)

	if event.is_action_pressed("remove"):
		if cell == 5:
			pass
		elif cell == 6:
			set_cell(tile.x, tile.y, 5)
		elif cell == 7:
			set_cell(tile.x, tile.y, 6)

	elif event.is_action_pressed("place"):
		if cell == 5:
			set_cell(tile.x, tile.y, 6)
		elif cell == 6:
			set_cell(tile.x, tile.y, 7)
		else:
			pass
	pass

extends TileMap

func _input(event: InputEvent) -> void:
	if event.is_action_pressed("remove"):
		var tile = world_to_map(get_global_mouse_position())
		set_cell(tile.x, tile.y, -1)
	elif event.is_action_pressed("place"):
		var tile = world_to_map(get_global_mouse_position())
		set_cell(tile.x, tile.y, 6)
	pass

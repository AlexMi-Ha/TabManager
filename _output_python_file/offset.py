from os import path

import guitarpro


# Returns all track numbers that should be offset (so no percussion tracks)
def unfold_tracknumber(tracks):
    for number, track in enumerate(tracks, start=1):
        if not track.isPercussionTrack:
            yield number



def main(source, dest, semitones):
	# load the file
    song = guitarpro.parse(source)
	# go through the to-edit tracks
    for number in unfold_tracknumber(song.tracks):
        track = song.tracks[number - 1]
		# change offset
        track.offset = semitones
    if dest is None:
        dest = 'temp.gp5'
	# save file 
    guitarpro.write(song, dest)


# Argument parser 
# Use 'python offset.py --help' for help
if __name__ == '__main__':
    import argparse

    def bitarray(string):
        return int(string, base=2)

    def tracknumber(string):
        if string == '*':
            return string
        else:
            return int(string)

    description = """
        Transpose tracks of GP tab by N semitones.
        """
    parser = argparse.ArgumentParser(description=description)
    parser.add_argument('source',
                        metavar='SOURCE',
                        help='path to the source tab')
    parser.add_argument('dest',
                        metavar='DEST', nargs='?',
                        help='path to the processed tab')
    parser.add_argument('-b', '--by', type=int, required=True, metavar='N', default = 0, dest='semitones',
                        help='transpose by N steps')
    args = parser.parse_args()
    kwargs = dict(args._get_kwargs())
    main(**kwargs)
package refactoringgolf.store;

public class ImageInfo {

	public String path;

	public ImageInfo(String path) {
		this.path = path;
	}

	public String getPath() {
		return path;
	}

	public String getImageType() {
		return path.substring(path.indexOf(".") + 1);

	}
}

#include <string>
#include <windows.h>

namespace CPP
{
	class PrinterInfo
	{
	public:
		std::string getDefaultPrinterInfo() const
		{
			char szPrinterName[255];
			unsigned long lPrinterNameLength;
			GetDefaultPrinter(szPrinterName, &lPrinterNameLength);

			return std::string(szPrinterName);
		}
	};
}
